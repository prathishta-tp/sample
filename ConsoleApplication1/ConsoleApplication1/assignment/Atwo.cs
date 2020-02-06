using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Atwo
    {
        public static void Main(string[] args)
        {
            string Abb;
            Console.WriteLine("enter Abbreviation");
            Abb = Console.ReadLine();

            switch (Abb)
            {
                case "Mktg.,":
                case "mktg":
                case "mrkt":
                    Console.WriteLine("Marketing");
                    break;
                case "Hr":
                case "hr":
                    Console.WriteLine("Human Resources");
                    break;
               
                case "accts":
                    Console.WriteLine("Accounts");
                    break;
                case "trg":
                case "Trg":
                    Console.WriteLine("Training");
                    break;
                default:
                    Console.WriteLine("no abbreviation");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
