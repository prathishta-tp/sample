using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Aten
    {
       public static void swap(ref int A, ref int B)
        {
            int temp;
            temp = A;
            A = B;
            B = temp;
        }
       public static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            b = Convert.ToInt32(Console.ReadLine());
            swap(ref a,ref b);
            Console.WriteLine("1st no is {0} \n 2nd no is {1}",a,b);
        }
    }
}
