using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home13l
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();

                double firstValue, secondValue;
                string action;

                try 
                {
                    Console.WriteLine("Value 1: ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Value 2: ");
                    secondValue = double.Parse(Console.ReadLine());
                } 
                catch
                {
                    Console.WriteLine("Not numbers");
                    Console.ReadLine();
                    continue;
                }

                

                Console.WriteLine("choose operation: '+' '*' '-' '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;

                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;

                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;

                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;

                    default:
                        Console.WriteLine("sth wrong");
                        break;
                }
                Console.ReadLine();
            }
            
        }
    }
}
