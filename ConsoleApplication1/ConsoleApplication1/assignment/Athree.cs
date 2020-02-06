using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Athree
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("enter first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("qoutient="+x / y);
            Console.WriteLine("remainder="+x % y);
        }
    }
}
