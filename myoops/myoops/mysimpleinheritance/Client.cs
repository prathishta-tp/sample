using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.mysimpleinheritance
{
    class Client
    {
        static void Main(string[] args)
        {
            Eaccount ea;
            ea = new Eaccount();//memory occupied=AccountHolder+Eaccount
            ea.eaDisplay();
            Console.WriteLine("\n\n");
            ea.ahDisplay();//this is also possible
        }
    }
}
