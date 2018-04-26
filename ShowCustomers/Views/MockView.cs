using System;
using System.Collections.Generic;

namespace ShowCustomers.View  
{
    public class MockView : IBank
    {
        public string DisplayUser { get;  set; }
        public string CurrentAccount { get; set; }
        public string BudgetAccount { get; set; }
        public string AmountText { get; set; }


        public bool CurrentModifyRadio { get; set; }
        public bool BudgetModifyRadio { get; set; }

        public string AccountStatusText { get; set; }

        public string DatePick { get; set; }
        public IEnumerable<string[]> BudgetList { get; set; }
        public IEnumerable<string[]> CurrentList { get; set; }
        public string BudgetTotal { get; set; }
        public string CurrentTotal { get; set; }
        public string NameText { get; set; }
        public string CPRText { get; set; }
        public string AddressText { get; set; }
        public string error_NameText { get; set; }
        public string error_CPRText { get; set; }
        public string error_AddressText { get; set; }
        public bool CurrentCreateRadio { get; set; }
        public bool BudgetCreateRadio { get; set; }

        public event Action OnAddCustomer;
        public event Action OnGetCustomer;
        public event Action OnLogOut;
        public event Action OnCreateAccount;
        public event Action OnInsert;
        public event Action OnTextChange;

        public void ClearTransactions()
        {
          
        }
    }
 
}
