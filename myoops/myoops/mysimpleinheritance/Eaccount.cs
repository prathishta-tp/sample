using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.mysimpleinheritance
{
    class Eaccount:Acoountholder //1 variable (3+1)
    {
        public String sCardNo;

        public Eaccount()
        {
            sCardNo = "1111 3333 5555 6666";
            Console.WriteLine("inside eaccount constructor");
        }

        public void eaDisplay()
        {
            Console.WriteLine("eaccount display function");
            Console.WriteLine("cardno: "+sCardNo);
            ahDisplay();
        }
    }
}
