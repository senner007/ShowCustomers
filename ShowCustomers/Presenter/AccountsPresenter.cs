using System;
using System.Linq;
using ShowCustomers.Model;
namespace ShowCustomers.Presenter
{
    public class AccountsPresenter : BankPresenter 
    {
        public void GetTransactions()
        {
            // Performance kan forbedres
            Console.WriteLine("Get Transactions");
            // .? c# 6 null conditional operator
            _manage.GetBudgetAccount(_loginCPR)?.Transactions.ForEach(b => _view.BudgetList = insertArr(b));

            _manage.GetCurrentAccount(_loginCPR)?.Transactions.ForEach(c => _view.CurrentList = insertArr(c));

            string[] insertArr(Transaction trans) => new string[3] {
                trans.Date,
                trans.Value.Decimals2(),
                trans.Total.Decimals2()
            };

        }
        private bool _Insert()
        {
            if (!determine.IfDec(_view.AmountText)) return false;
            bool success = false;

            if (_view.BudgetModifyRadio)
            {
                if (_manage.BudgetTransact(_loginCPR, _view.DatePick, Convert.ToDecimal(_view.AmountText)))
                        _view.BudgetList = insertArr(_manage.GetBudgetAccount(_loginCPR));              
            }
            else if (_view.CurrentModifyRadio)
            {
                if (_manage.CurrentTransact(_loginCPR, _view.DatePick, Convert.ToDecimal(_view.AmountText)))
                        _view.CurrentList = insertArr(_manage.GetCurrentAccount(_loginCPR));
            }
            string[] insertArr(Account _account)
            {
               success = true;
               return new string[3] {
                    _account.Transactions.Last().Date,
                    _account.Transactions.Last().Value.Decimals2(),
                    _account.Total.Decimals2()
                };
            }      
            return success;

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
