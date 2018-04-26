using System;
using System.Collections.Generic;

namespace ShowCustomers.View  // TODO : split op i flere view og presenters
{
    public interface IBank
    {
        string DisplayUser { set; }

        string CurrentAccount { set; }
        string BudgetAccount { set; }

        string AmountText { get; set; }

        bool CurrentCreateRadio { get; }
        bool BudgetCreateRadio { get; }

        bool CurrentModifyRadio { get; }
        bool BudgetModifyRadio { get; }

        string DatePick { get; }

        IEnumerable<string[]> BudgetList { set; }
        IEnumerable<string[]> CurrentList { set; }

        string BudgetTotal { set; }
        string CurrentTotal { set; }

        string NameText { get; set; }
        string CPRText { get; set; }
        string AddressText { get; set; }

        string AccountStatusText { get; set; }

        string error_NameText { set; }
        string error_CPRText { set; }
        string error_AddressText { set; }

        event Action OnAddCustomer;
        event Action OnGetCustomer;
        event Action OnLogOut;
        event Action OnCreateAccount;
        event Action OnInsert;
        event Action OnTextChange;

       // void ClearTransactions();

    }
 
}
