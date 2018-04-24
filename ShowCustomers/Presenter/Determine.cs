using System;
using System.Text.RegularExpressions;

namespace ShowCustomers.Presenter
{
    public class Determine
    {
        public bool IfName(string input) => Regex.IsMatch(input, @"^((?!.*[\s])(?=.*[A-Z])(?=.*\d).{8,15})") == true ? true : false;
        
        public bool IfDec(string input) => Decimal.TryParse(input, out decimal parsed) ? true : false; 
        
        public bool IfCPR(string input) => Int64.TryParse(input, out Int64 parsed) && parsed.ToString().Length == 10 ? true : false;
        
        public bool IfAddress(string input) => Regex.IsMatch(input, @"^([a-zA-Z]).+\s(?=.*[0-9]).*$") == true ? true : false; // TODO: forbedre adressekode
        
        public bool IfValidUser(string name, string cpr, string address)
        {
            return (IfName(name) == true && IfCPR(cpr) == true && IfAddress(address) == true) ? true : false;
        }
    }

}
