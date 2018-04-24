namespace ShowCustomers.Model
{
    public class Customer : ICPR
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public long CPR { get; set; }
    }

}
