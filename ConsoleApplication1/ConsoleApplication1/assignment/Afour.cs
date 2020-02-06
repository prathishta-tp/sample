using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Afour
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            Console.WriteLine("enter first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            z = int.Parse(Console.ReadLine());
            
            if(x>y && x>z)
            {
                Console.WriteLine("largest no is:"+x);
            }
            else if(y>x && y>z)
            {
                Console.WriteLine("largest no is:"+y);
            }
            else
            {
                Console.WriteLine("largest no is:"+z);
            }
        }
    }
}
