using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.myabstractdemo
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("demo on abstract class");
            TaxRule tr;
            // tr = new TaxRule();//cannot create object for abstract class
            tr = new IndiaTax();
            tr.display();
            Console.WriteLine(tr.calculate(510000));//this is possible
            //tr.welcomeNote();//cannot access this function
        }
    }
}
