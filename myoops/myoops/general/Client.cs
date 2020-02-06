using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.general
{
    class Client
    {
        static void Main(string[] args)
        {
            Mybase mb;
            mb = new Mybase();
            // mb.defaultDisplay();//this will not work as it is private by default
            mb.pubDisplay();
           // mb.pvtDisplay();//private function cannot be called
           // mb.prtDisplay();//this will not work as it is protected
            mb.intDisplay();
            mb.piDisplay();
        }
    }
}
