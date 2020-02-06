using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Asix
    {
        static void Main(string[] args)
        {
            int i = 0;
            int count;

            Console.WriteLine("Even Numbers :");
            Console.Write("Enter the Limit : ");
            count = int.Parse(Console.ReadLine());
            for (i = 1; i <= count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

          /*  Console.WriteLine("\nOdd Numbers :");
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }*/

            Console.WriteLine();
        }
    }
}
