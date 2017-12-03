using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifraoJuntoNumeroFormatacaoToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal value = 1106.20m;
            Console.WriteLine($"Current Culture: {CultureInfo.CurrentCulture.Name}");
            Console.WriteLine($"Currency Symbol: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");
            Console.WriteLine($"Currency Value:  {NumberFormatInfo.CurrentInfo.CurrencySymbol} {value:N2}");
        }
    }
}
