using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOneLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Enter first value: ");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter last value: ");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if(currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum = oddNumbersSum + currentValue;
                }
                currentValue++;
            }

            Console.WriteLine("Odd Numbers: " + oddNumbersCount);
            Console.WriteLine("Even Numbers: " + evenNumbersCount);
            Console.WriteLine("Odd Sum Numbers: " + oddNumbersSum);
            Console.WriteLine("Even Sum Numbers: " + evenNumbersSum);
            Console.ReadLine();
            
        }
    }
}
