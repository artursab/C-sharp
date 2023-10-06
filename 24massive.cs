using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24massive
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myArray1 = new int[5];
            int[] myArray2 = new int[] { 3, 4, 5, 6 };
            int[] myArray3 = {3,4,5,6};


            int[] myArray = Enumerable.Range(4, 5).ToArray();


            Console.ReadLine();
        }
    }
}
