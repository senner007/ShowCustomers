using ShowCustomers.Views;


namespace ShowCustomers.Presenter
{
    public abstract class BankPresenter
    {      
        protected ICustomer _view;      
        protected Determine determine = new Determine(); // should maybe be static

        protected void ShowLabel()
        {
            _view.error_NameText = determine.IfName(_view.NameText) ? "" : "Name cannot contain white spaces, must contain at least 1 number, 1 capital letter, and length of 8-15 characters";
            //https://stackoverflow.com/questions/21034258/password-validation-regex-to-disallow-whitespaces
            _view.error_CPRText = determine.IfCPR(_view.CPRText) ? "" : "Type valid 10 digit CPR";
            _view.error_AddressText = determine.IfAddress(_view.AddressText) ? "" : "Address is to begin with a letter, must contain white space, must contain 1 number";
        }

        protected void ClearLabel()
        {
            _view.error_NameText = "";
            _view.error_CPRText = "";
            _view.error_AddressText = "";
            _view.NameText = "";
            _view.CPRText = "";
            _view.AddressText = "";      
        }
       
    }
   

}
