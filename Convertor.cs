using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double UsdToRub = 100;
            double UsdToUah = 50;
            double Usd;

            Console.WriteLine("Enter value in usd");

            Usd = double.Parse(Console.ReadLine());

            Console.WriteLine(Usd + " USD to Rub " + Usd *  UsdToRub);

            Console.WriteLine(Usd + " USD to Uah " + Usd * UsdToUah);
        }
    }
}
