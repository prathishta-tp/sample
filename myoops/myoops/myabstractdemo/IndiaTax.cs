using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.myabstractdemo
{
   class IndiaTax:TaxRule
    {
        public override void display()
        {
            welcomeNote();
            Console.WriteLine("tax as per indian rule"+calculate(499000));
        }
        void welcomeNote()
        {
            Console.WriteLine("welcome to india tax class");
        }

    }
}
