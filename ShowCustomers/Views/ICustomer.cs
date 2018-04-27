using System;
using System.Collections.Generic;

namespace ShowCustomers.Views  // TODO : split op i flere view og presenters
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
