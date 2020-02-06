using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.mysimpleinheritance
{
    class Acoountholder
    {
        int iAccountNumber;
        String sName;
        double dBalance;

        public Acoountholder()
        {
            iAccountNumber = 1;
            sName = "nitin";
            dBalance = 56000.50;
            Console.WriteLine("inside accountHolder constructor");
        }

        public void ahDisplay()
        {
            Console.WriteLine("ah display function");
            Console.WriteLine("account number: "+iAccountNumber);
            Console.WriteLine("name: "+sName);
            Console.WriteLine("balance: "+dBalance);
        }

    }
}
