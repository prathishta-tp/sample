using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.hidingmethod
{
    class Mydev1:Mybase
    {
        int iValue2;
        public Mydev1()
        {
            iValue2 = 20;
        }
        public new void display()
        {
            base.display();
            Console.WriteLine("value of iValue2: "+iValue2);
        }
    }
}
