using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Value 1: ");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Value 2: ");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("choose operation: '+' '*' '-' '/'");
            action = Console.ReadLine();

            if (action == "+")
            {
               Console.WriteLine(firstValue + secondValue);
            }
            else if (action == "-") 
            {
                Console.WriteLine(firstValue - secondValue);
            }
            else if (action == "*") 
            {
                Console.WriteLine(firstValue * secondValue);
            }
            else if (action == "/")
            {
                if (secondValue == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(firstValue / secondValue);
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.ReadLine();
        }
    }
}
