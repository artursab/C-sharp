using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apponc_func
{
    internal class Program
    {

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Result: " + result);
        }

        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);

            PrintResult(c);   

            Console.ReadLine();
        }
    }
}
