using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowCustomers.Model
{ 
    public class ManageAccounts : Bank
    {
        public Customer UpdateCustomer(long cpr, string name, string address)
        {
            Customer customer = FindCustomer(cpr);
            if (customer != null)
            {
                if (FindByName(name) == null)
                {
                    Console.WriteLine("MODEL : Customer name updated");
                    customer.Name = name;
                    return customer;
                }
                Console.WriteLine("MODEL : Customer address updated");
                customer.Address = address;
            }
            return null;
        }
        public Customer CreateCustomer(long cpr, string name, string address)
        {
            if (FindCustomer(cpr) == null && FindByName(name) == null)
            {
                Console.WriteLine("MODEL : Customer created");
                Customer customer = new Customer { CPR = cpr, Name = name, Address = address, NickName = cpr.ToString().Substring(0, 6) + "Bruger" };
                _customers.Add(customer);
                return customer;
            }
            return null;
        }
        public bool CurrentCreate(long cpr) => _AddAccount(GetCurrentAccount(cpr), _currentAccounts, 123, cpr);     
        public bool BudgetCreate(long cpr) =>  _AddAccount(GetBudgetAccount(cpr), _budgetAccounts, 456, cpr);
        
        private bool _AddAccount(Account account, List<Account> list, long num, long cpr)
        {
            if (account != null) return false;
            list.Add(new Account { CPR = cpr, DateInit = "01-08-2018", AccountNumber = num, Total = 0, Transactions = new List<Transaction>() });
            Console.WriteLine("MODEL : Account created");
            return true;
        }

        public bool CurrentTransact(long cpr, string date, decimal value) =>  _Transact(GetCurrentAccount(cpr), date,  value);
        public bool BudgetTransact(long cpr, string date, decimal value) => _Transact(GetBudgetAccount(cpr), date, value);

        private bool _Transact(Account account, string date, decimal value)
        {
            if (account == null) return false;
            account.Transactions.Add(new Transaction { Date = date, Message = "Inserting money", Value = value, Total = account.Total + value });
            account.Total = account.Total + value;
            Console.WriteLine("MODEL : Transaction completed");
            return true;
        }
        private T FindByCPR<T>(long cpr, List<T> list) where T : ICPR => list.FirstOrDefault(c => c.CPR == cpr);
        public Customer FindByName(string name) => _customers.FirstOrDefault(c => c.Name == name);
        public Customer FindCustomer(long cpr) => FindByCPR(cpr, _customers); 
        public Account GetBudgetAccount(long cpr) => FindByCPR(cpr, _budgetAccounts);
        public Account GetCurrentAccount(long cpr) => FindByCPR(cpr, _currentAccounts);
    }
}
