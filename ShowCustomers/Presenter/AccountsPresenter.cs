using System;
using ShowCustomers.Models;
using ShowCustomers.Views;

namespace ShowCustomers.Presenter
{
    public class AccountsPresenter
    {
        private IAccounts _view;
        private CustomerPresenter _customerPresenter;
        private ManageAccounts _manage = new ManageAccounts();
        private Determine determine = new Determine();

        public AccountsPresenter(IAccounts view, CustomerPresenter customerPresenter)
        {
            Console.WriteLine("AccountsPresenter Constructor");
            _view = view;
            _customerPresenter = customerPresenter;  

            _view.OnCreateAccount += CreateAccount;
            _view.OnInsert += InsertTransaction;
            _customerPresenter.CallGetTransactions += GetTransactions;
            _customerPresenter.CallShowAccounts += ShowAccounts;
            _customerPresenter.CallClearAccounts += ClearAccounts;

        }

        private void GetTransactions()
        {
            Console.WriteLine("Get Transactions");
            long _loginCPR = _customerPresenter._loginCPR;

            _view.BudgetList = _manage.TransactionsToArray(_manage.GetBudgetAccount(_loginCPR));

            _view.CurrentList = _manage.TransactionsToArray(_manage.GetCurrentAccount(_loginCPR));

        }
        private bool _Insert()
        {
            long _loginCPR = _customerPresenter._loginCPR;
            if (!determine.IfDec(_view.AmountText)) return false;
            if (_view.BudgetModifyRadio)
            {
                var result = _manage.BudgetTransact(_loginCPR, _view.DatePick, Convert.ToDecimal(_view.AmountText));
                if (result != null)
                {
                    _view.BudgetList = result;
                    return true;
                };
            }
            else if (_view.CurrentModifyRadio)
            {
                var result = _manage.CurrentTransact(_loginCPR, _view.DatePick, Convert.ToDecimal(_view.AmountText));
                if (result != null)
                {
                    _view.CurrentList = result;
                    return true;
                };
            }
        return false;

        }
        private bool _Create()
        {
            long _loginCPR = _customerPresenter._loginCPR;
            if (_loginCPR == 0 || (!_view.CurrentCreateRadio && !_view.BudgetCreateRadio)) return false;
            return _view.BudgetCreateRadio ? _manage.BudgetCreate(_loginCPR) : _manage.CurrentCreate(_loginCPR);
        }

        private void CreateAccount() => ShowAccounts(_Create() , "Konto oprettet", "Konto ikke oprettet");
     
        private void InsertTransaction() => ShowAccounts(_Insert(), "Transaktion gennemført", "Transaktion ikke gennemført");         

        private void ShowAccounts(bool show, string message = "", string fail = "")
        {
            if (!show)
            {
                _view.AccountStatusText = fail;
                return;
            }
            long _loginCPR = _customerPresenter._loginCPR;
            _view.AccountStatusText = message;
            
            Account budget = _manage.GetBudgetAccount(_loginCPR);
            Account current = _manage.GetCurrentAccount(_loginCPR);            

            _view.BudgetAccount = budget?.AccountNumber.ToString(); 
            _view.CurrentAccount = current?.AccountNumber.ToString();

            _view.BudgetTotal = budget?.Total.Decimals2();
            _view.CurrentTotal = current?.Total.Decimals2();
        }
        
        private void ClearAccounts()
        {
            _view.AmountText = "";
            _view.BudgetList = null; // fjern transaktioner
            _view.CurrentList = null;
        }
    }
    
    
}
