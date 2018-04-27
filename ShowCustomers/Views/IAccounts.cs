using System;
using System.Collections.Generic;

namespace ShowCustomers.Views
{
    public interface IAccounts
    {
        string AccountStatusText { get; set; }

        string BudgetTotal { set; }
        string CurrentTotal { set; }

        bool CurrentCreateRadio { get; }
        bool BudgetCreateRadio { get; }

        bool CurrentModifyRadio { get; }
        bool BudgetModifyRadio { get; }

        string CurrentAccount { set; }
        string BudgetAccount { set; }

        string AmountText { get; set; }

        string DatePick { get; }

        IEnumerable<string[]> BudgetList { set; }
        IEnumerable<string[]> CurrentList { set; }

        event Action OnCreateAccount;
        event Action OnInsert;
    }
}
