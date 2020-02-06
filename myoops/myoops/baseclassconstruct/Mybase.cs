using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.baseclassconstruct
{
    class Mybase
    {
        String sY;
        public Mybase()
        {
            sY = "bond";
            Console.WriteLine("inside mybase constructor");
        }

        public Mybase(String s)
        {
            sY = "mybase value" + s;
            Console.WriteLine("inside mybase constructor with parameter");
        }

        public void baseDisplay()
        {
            Console.WriteLine("value of sY: "+sY);
        }
    }
}
