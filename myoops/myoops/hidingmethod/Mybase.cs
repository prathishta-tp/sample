using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.hidingmethod
{
    class Mybase
    {
        int iValue1;
        public Mybase()
        {
            iValue1 = 10;
        }
        public virtual void display()
        {
            Console.WriteLine("value of iValue1: "+iValue1);
        }
    }
}
