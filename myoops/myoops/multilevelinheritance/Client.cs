using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.multilevelinheritance
{
    class Client
    {
        public static void Main()
        {
            Automobile nm;
           // NissanMicra nm;
            nm = new NissanMicra();
            nm.display();
           // nm.dip();
            Console.WriteLine("-----------------------------------");
            return;


            //Automobile a;
            //a = new NissanMicra(); //normally we dont write like this
            //a.display();
            ////a.dip();
            //return;

            //Automobile a;
            //a = Factory.GetObject(Console.ReadLine());
            //a.display();
        }
    }
}
