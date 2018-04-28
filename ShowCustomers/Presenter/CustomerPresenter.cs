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
        private ManageAccounts _manage = new ManageAccounts();

        public CustomerPresenter(ICustomer view)
        {
            Console.WriteLine("CustomerPresenter Constructor");  
            _view = view;
            _view.OnAddCustomer += CreateUpdateCustomer;
            _view.OnGetCustomer += GetCustomer;
            _view.OnTextChange += ShowLabel;         
            _view.OnLogOut += LogOut;
           
        }

        private void CreateUpdateCustomer() 
        {          
            if (!determine.IfValidUser(_view.NameText, _view.CPRText, _view.AddressText)) return;

            long cpr = Convert.ToInt64(_view.CPRText);
            // Update customer
            if (LoginCPR != 0 && cpr == LoginCPR) // opdater bruger kræver bruger indlæst og at indtastet cpr er lig brugers
            {
                    DisplayCustomer(_manage.UpdateCustomer(LoginCPR, _view.NameText, _view.AddressText), 
                        "Navn og adresse opdateret. Bruger er indlæst",  
                        "Adresse opdateret. Navn ikke opdateret. Navn findes i forvejen.");

            }
            // Create Customer
            else if (LoginCPR == 0) // opret bruger kræver, at der er logged ud
            {
                    DisplayCustomer(_manage.CreateCustomer(cpr, _view.NameText, _view.AddressText), 
                        "er oprettet. Bruger indlæst",  
                        "Ikke oprettet. Navn eller CPR findes i forvejen");
            }
        }

        private void GetCustomer()
        {
            // return hvis både navn og cpr er indtastet
            if (_view.CPRText != "" && _view.NameText != "") return;
            
            // Indlæs ved cpr
            if (determine.IfCPR(_view.CPRText))
            {
                DisplayCustomer(_manage.FindCustomer(Convert.ToInt64(_view.CPRText)), 
                    "er indlæst ved CPR", 
                    "CPR ikke fundet");
            } //Indlæs ved navn              
            else if (determine.IfName(_view.NameText))
            {
                DisplayCustomer(_manage.FindByName(_view.NameText), 
                    "er indlæst ved navn", 
                    "Navn ikke fundet");
            }             
        }
        private void DisplayCustomer(Customer customer, string message, string fail)
        { 
            ClearLabel(); // slet alle tekstfelter og tekstlabels og listviews
            CallClearAccounts(); // call ClearAccounts from accounts presenter
            LoginCPR = customer != null ? customer.CPR : 0; // sæt login. 0 hvis ikke indlæst
            _view.DisplayUser = customer != null ? customer.NickName + " " + message : fail + " Ikke indlæst"; // Vis meddelelse
            CallShowAccounts(true, "", ""); //  Call ShowAccounts from accounts presenter
            CallGetTransactions();   // call GetTransactions from accounts presenter                 
        }
        private void LogOut()
        {        
            DisplayCustomer(null, "", "Indtast enten navn eller CPR.");
        }
    }
}
