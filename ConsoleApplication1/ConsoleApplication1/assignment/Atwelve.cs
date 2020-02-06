using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Atwelve
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type something= ");
            string str = Console.ReadLine();
            
            if(str=="no")
            {
                Console.WriteLine("Bye");
                Environment.Exit(0);
            }
            else
                Console.WriteLine(str);

        }
    }
}
