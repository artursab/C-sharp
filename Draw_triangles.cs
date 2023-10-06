using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 triangle
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());


            for (int i = 0; i < height; i++)
            {
                for (int j= 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }


            //2 triangle
            Console.Write("Enter height: ");
            int mheight = int.Parse(Console.ReadLine());


            for (int i = 0; i < mheight; i++)
            {
                for (int j = mheight; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }



            //3 triangle
            Console.Write("Enter height: ");
            int kheight = int.Parse(Console.ReadLine());


            for (int i = 0; i < kheight; i++)
            {
                for (int j = kheight; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            //4 triangle
            Console.Write("Enter height: ");
            int aheight = int.Parse(Console.ReadLine());


            for (int i = 0; i < aheight; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = aheight; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }


            //triangle with cursor possition
            Console.Write("Enter height: ");
            int hheight = int.Parse(Console.ReadLine());


            for (int i = 0; i < hheight; i++)
            {
                Console.SetCursorPosition(hheight - i, i + 1);

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
