namespace ShowCustomers.Models
{
    public struct Transaction
    {
        public string Date { get; set; }
        public string Message { get; set; }
        public decimal Value { get; set; }
        public decimal Total { get; set; }
    }
}
