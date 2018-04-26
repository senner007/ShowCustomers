using ShowCustomers.View;
using ShowCustomers.Models;


namespace ShowCustomers.Presenter
{
    public abstract class BankPresenter
    {      
        protected IBank _view;
        protected long _loginCPR = 0;
        protected ManageAccounts _manage;
        protected Determine determine = new Determine();

        protected void ShowLabel()
        {
            _view.error_NameText = determine.IfName(_view.NameText) ? "" : "Brugernavn skal indeholde 1 tal, et stort bogstav, ingen mellemrum og bestå af 8-15 tegn";
            //https://stackoverflow.com/questions/21034258/password-validation-regex-to-disallow-whitespaces
            _view.error_CPRText = determine.IfCPR(_view.CPRText) ? "" : "Indtast CPR med 10 cifre";
            _view.error_AddressText = determine.IfAddress(_view.AddressText) ? "" : "Adresse skal starte med et bogstav, indeholde et mellemrum og mindst 1 tal";
        }
        protected void ClearLabel()
        {
            _view.error_NameText = "";
            _view.error_CPRText = "";
            _view.error_AddressText = "";
            _view.NameText = "";
            _view.CPRText = "";
            _view.AddressText = "";
            _view.AmountText = "";
        }
       
    }
   

}
