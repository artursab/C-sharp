using System;


namespace Apponc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Enter 1 value: ");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2 value: ");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3 value: ");

            thirdValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;

            double multResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Sum: " + sumResult);

            Console.WriteLine("Mult: " +  multResult);
        }
    }
}
