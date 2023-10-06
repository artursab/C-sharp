using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsmass
{
    internal class Program
    {

        static void PrintLine(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }    
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter Symbol: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("Enter quantity of symbols: ");
            uint symbolsCount = uint .Parse(Console.ReadLine());

            PrintLine(symbol, symbolsCount);
            Console.ReadLine();
        }
    }
}
