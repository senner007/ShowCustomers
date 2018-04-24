using System;
using System.Collections.Generic;

namespace ShowCustomers.Model
{
    public abstract class Bank
    {
        protected static readonly List<Customer> _customers;
        protected static readonly List<Account> _currentAccounts;
        protected static readonly List<Account> _budgetAccounts;

        static Bank() // static constructor
        {
            _currentAccounts = new List<Account>() {  
                    new Account { CPR =  1111111111 , DateInit = "01-08-2018", AccountNumber = 123, Total = 100, Transactions = new List<Transaction>()}
                };
            _budgetAccounts = new List<Account>() {
                    new Account { CPR =  1111111111 , DateInit = "01-08-2018", AccountNumber = 456, Total = 200, Transactions = new List<Transaction>()}
                };

            _customers = new List<Customer>() {
                    new Customer { CPR =  1111111111 , Name = "Smart001", Address = "Road 1", NickName = "111111Bruger"},
                    new Customer { CPR =  2222222222 , Name = "Smart002", Address = "Road 2", NickName = "222222Bruger"}
                };
        }
   
    }
}
