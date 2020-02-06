using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Afourteen
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

           
            for (int i = 0; i < array.Length; i++)
            {
                 array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("array[" + i + "}= " + array[i]);
            }
            Console.WriteLine("enter 1 for asc\n 2 - desc");
            string choice = Console.ReadLine();
            if(choice=="1")
            { Array.Sort(array); }
            else
            { 
            Array.Sort(array);
            Array.Reverse(array);
            }
            for (int i = 0; i < array.Length; i++)
            {
               
                Console.WriteLine("array[" + i + "}= " + array[i]);
            }
        }
    }
}
