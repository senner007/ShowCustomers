using System.Globalization;

namespace ShowCustomers.Models
{
    static class Extensions
    {
        public static string Decimals2(this decimal num) => num.ToString("#.00", CultureInfo.InvariantCulture);
    }
}
