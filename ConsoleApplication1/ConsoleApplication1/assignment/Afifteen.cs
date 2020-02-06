using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Afifteen
    {
        static void Multiply(int x, int y)
        {

            int z = x * y;
            Console.WriteLine("the product of these two nmbers= " + z);
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter first nmber");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second nmber");
            y = int.Parse(Console.ReadLine());
            Multiply(x, y);
        }
    }
}
