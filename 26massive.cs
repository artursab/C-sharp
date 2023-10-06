using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26massive_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter quantity of massive elements:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter ellement of massive under index {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMassive output: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }


            //part 2: reverse output

            Console.WriteLine("\nReverse massive output: ");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            //part 3: even

            int result = 0;

            Console.WriteLine("\nEven numbers from massive output: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    //result = result + myArray[i];
                    result += myArray[i];
                }
            }
            Console.WriteLine(result);

            //part 4: min num in massive

            int minValue = myArray[0];

            Console.WriteLine("\nMin number from massive output: ");

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.WriteLine(minValue);


            Console.ReadLine();
        }
    }
}
