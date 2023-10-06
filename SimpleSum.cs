using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Enter 1 value: ");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2 value: ");

            secondValue = double.Parse(Console.ReadLine());

            double res = (firstValue + secondValue)/2;

            Console.WriteLine(res);
        }
    }
}
