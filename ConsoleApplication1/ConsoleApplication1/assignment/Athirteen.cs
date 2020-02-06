using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Athirteen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            display(ref name);
        }
        static void display(ref string name )
        {
            Console.WriteLine("Hello "+name);
        }
    }

}
