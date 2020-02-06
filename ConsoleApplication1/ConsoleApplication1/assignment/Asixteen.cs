using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Asixteen
    {
        static void Main(string[] args)
        {
            int item;
            Console.WriteLine("enter nmber of items");
            item = int.Parse(Console.ReadLine());
            double discount = (item > 2) ? (0.2 * item) : (0.1 * item);
            Console.WriteLine("the discont is " + discount);
        }
    }
}
