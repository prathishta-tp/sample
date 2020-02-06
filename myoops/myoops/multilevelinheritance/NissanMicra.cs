using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.multilevelinheritance
{
    class NissanMicra:Car
    {
        String sStartMode;

        public NissanMicra()
        {
            sStartMode = "self start";
            Console.WriteLine("inside nissan micra constructor");
        }

        public override void display()
        {
            Console.WriteLine("startmode: "+sStartMode);
            base.display();
        }

        public void dip()
        {
            Console.WriteLine("dip fun");
        }
    }
}
