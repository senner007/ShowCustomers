using ShowCustomers.Model;
using ShowCustomers.View;
using System;

namespace ShowCustomers.Presenter
{
    public class InitPresenter : CustomerPresenter
    {
        public InitPresenter(IBank ibank)
        {
            Console.WriteLine("Init Constructor");
            _manage = new ManageAccounts();
            _view = ibank;

            _view.OnAddCustomer += CreateUpdateCustomer;
            _view.OnGetCustomer += GetCustomer;
            _view.OnTextChange += ShowLabel;
            _view.OnCreateAccount += CreateAccount;
            _view.OnLogOut += LogOut;
            _view.OnInsert += InsertTransaction;
        }

    }
}
