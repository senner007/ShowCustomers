using System;
using ShowCustomers.Models;
using ShowCustomers.Views;

namespace ShowCustomers.Presenter 
{

    public delegate void EventWithArgs(bool success, string message, string fail); // necessary ?

    public class CustomerPresenter : BankPresenter
    {
        public event Action CallGetTransactions;
        public event Action CallClearAccounts;
        public event EventWithArgs CallShowAccounts;
        public long LoginCPR { get; private set; } = 0;
        ManageAccounts _manage = new ManageAccounts();

        public CustomerPresenter(ICustomer view)
        {
            Console.WriteLine("CustomerPresenter Constructor");  
            _view = view;
            _view.OnAddCustomer += CreateUpdateCustomer;
            _view.OnGetCustomer += GetCustomer;
            _view.OnTextChange += ShowLabel;         
            _view.OnLogOut += LogOut;
           
        }
        // default is internal
        void CreateUpdateCustomer() 
        {          
            if (!determine.IfValidUser(_view.NameText, _view.CPRText, _view.AddressText)) return;

            long cpr = Convert.ToInt64(_view.CPRText);
            // Update customer
            if (LoginCPR != 0 && cpr == LoginCPR) // updating user requires user logged in and a CPR to match users
            {
                DisplayCustomer(_manage.UpdateCustomer(LoginCPR, _view.NameText, _view.AddressText), 
                "Name and address updated. User logged in",  
                "Address updated. Name not updated, Name already exists.");

            }
            // Create Customer
            else if (LoginCPR == 0) // creating a customer requires that no user is logged in
            {
                DisplayCustomer(_manage.CreateCustomer(cpr, _view.NameText, _view.AddressText), 
                "created. User logged in",  
                "User not Created. Name or CPR already exists");
            }
               
        }

        void GetCustomer()
        {
            // only permit log in by either user name or CPR 
            if (_view.CPRText != "" && _view.NameText != "") return;
            
            // Get user by CPR (personal identity)
            if (determine.IfCPR(_view.CPRText))
            {
                DisplayCustomer(_manage.FindCustomer(Convert.ToInt64(_view.CPRText)), 
                "is logged in by CPR", 
                "CPR not found");

            } //Get user by name          
            else if (determine.IfName(_view.NameText))
            {
                DisplayCustomer(_manage.FindByName(_view.NameText), 
                "is logged in by name", 
                "Name not found");
            }             
        }

        void DisplayCustomer(Customer customer, string message, string fail)
        { 
            ClearLabel(); // clear user related textboxes and labels
            CallClearAccounts(); // call ClearAccounts from accounts presenter
            LoginCPR = customer != null ? customer.CPR : 0; // set login status. 0 if user not logged in.
            _view.DisplayUser = customer != null ? customer.NickName + " " + message : fail + " - logged out"; // Show message
            CallShowAccounts(true, "", ""); //  Call ShowAccounts from accounts presenter
            CallGetTransactions();   // call GetTransactions from accounts presenter                 
        }

        void LogOut() => DisplayCustomer(null,"", "Insert either name or CPR");
    }
}
