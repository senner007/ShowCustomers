using System.Collections.Generic;

namespace ShowCustomers.Models
{
    public class Account :  ICPR
    {
        public string DateInit { get; set; }
        public long AccountNumber { get; set; }
        public long CPR { get; set; }
        public decimal Total { get; set; }
        public List<Transaction> Transactions;
      
    }

}
