using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowCustomers.Models
{
    public static class Extensions
    {
        public static string Decimals2(this decimal num) => num.ToString("#.00", CultureInfo.InvariantCulture);
    }
}
