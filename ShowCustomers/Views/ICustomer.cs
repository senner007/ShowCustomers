using System;

namespace ShowCustomers.Views  
{
    public interface ICustomer
    {
        string DisplayUser { set; }

        string NameText { get; set; }
        string CPRText { get; set; }
        string AddressText { get; set; }

        string error_NameText { set; }
        string error_CPRText { set; }
        string error_AddressText { set; }

        event Action OnAddCustomer;
        event Action OnGetCustomer;
        event Action OnLogOut;

        event Action OnTextChange;

    }

}
