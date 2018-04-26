using System;
using System.Collections.Generic;
using System.Linq;
using ShowCustomers.Models;
namespace ShowCustomers.Presenter
{
    public class AccountsPresenter : BankPresenter 
    {
        public void GetTransactions()
        {
            Console.WriteLine("Get Transactions");

            _view.BudgetList = _manage.TransactionsToArray(_manage.GetBudgetAccount(_loginCPR));

            _view.CurrentList = _manage.TransactionsToArray(_manage.GetCurrentAccount(_loginCPR));

        }
        private bool _Insert()
        {
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
            if (_loginCPR == 0 || (!_view.CurrentCreateRadio && !_view.BudgetCreateRadio)) return false;
            return _view.BudgetCreateRadio ? _manage.BudgetCreate(_loginCPR) : _manage.CurrentCreate(_loginCPR);
        }

        public void CreateAccount() => ShowAccounts(_Create() , "Konto oprettet", "Konto ikke oprettet");
     
        public void InsertTransaction() => ShowAccounts(_Insert(), "Transaktion gennemført", "Transaktion ikke gennemført");         

        public void ShowAccounts(bool show, string message = "", string fail = "")
        {
            if (!show)
            {
                _view.AccountStatusText = fail;
                return;
            }
            
            _view.AccountStatusText = message;
            
            Account budget = _manage.GetBudgetAccount(_loginCPR);
            Account current = _manage.GetCurrentAccount(_loginCPR);            

            _view.BudgetAccount = budget?.AccountNumber.ToString(); 
            _view.CurrentAccount = current?.AccountNumber.ToString();

            _view.BudgetTotal = budget?.Total.Decimals2();
            _view.CurrentTotal = current?.Total.Decimals2();
        }     
    }
    
    
}
