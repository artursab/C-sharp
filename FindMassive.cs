using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMass
{
    internal class Program
    {

        static int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) 
                {
                    return i;
                }
            }

            return -1;
        }

        static int[] GetRandomArray(uint legth, int minValue, int maxValue)
        {
            int[] myArray = new int[legth];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }


        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10,-5,20);

            int result = IndexOf(myArray, 1000);

            Console.WriteLine(result);
        }
    }
}
