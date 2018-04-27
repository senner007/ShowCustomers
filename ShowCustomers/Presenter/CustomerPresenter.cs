using System;
using ShowCustomers.Models;

namespace ShowCustomers.Presenter
{
    public class CustomerPresenter : AccountsPresenter
    {
        
        public void CreateUpdateCustomer() 
        {          
            if (!determine.IfValidUser(_view.NameText, _view.CPRText, _view.AddressText)) return;

            long cpr = Convert.ToInt64(_view.CPRText);
            // Update customer
            if (_loginCPR != 0 && cpr == _loginCPR) // opdater bruger kræver bruger indlæst og at indtastet cpr er lig brugers
            {
                    DisplayCustomer(_manage.UpdateCustomer(_loginCPR, _view.NameText, _view.AddressText), 
                        "Navn og adresse opdateret. Bruger er indlæst",  
                        "Adresse opdateret. Navn ikke opdateret. Navn findes i forvejen.");

            }
            // Create Customer
            else if (_loginCPR == 0) // opret bruger kræver, at der er logged ud
            {
                    DisplayCustomer(_manage.CreateCustomer(cpr, _view.NameText, _view.AddressText), 
                        "er oprettet. Bruger indlæst",  
                        "Ikke oprettet. Navn eller CPR findes i forvejen");
            }
        }

        public void GetCustomer()
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
            _loginCPR = customer != null ? customer.CPR : 0; // sæt login. 0 hvis ikke indlæst
            _view.DisplayUser = customer != null ? customer.NickName + " " + message : fail + " Ikke indlæst"; // Vis meddelelse
            ShowAccounts(true); // vis konti for bruger
            GetTransactions();  // hent transaktioner for bruger           
        }
        public void LogOut()
        {        
            DisplayCustomer(null, "", "Indtast enten navn eller CPR.");
        }
    }
}
