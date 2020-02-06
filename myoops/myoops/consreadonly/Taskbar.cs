using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.consreadonly
{
    class Taskbar
    {
        public const int x = 1;
        public const int y = 1;
        public readonly int x1 = 20;
        public readonly int y1;

        public Taskbar()
        {
            //x = 5;//not possible
            //y = 5;//not possible
            x1 = 25;
            y1 = 25;
        }

        public Taskbar(int pX1,int pY1)
        {
            x1 = pX1;
            y1 = pY1;
        }

        public void display()
        {
           // x = 8;//not possible
           // y = 8;//not possible
           // x1 = 35;//not possible
           // y1 = 35;//not possible
            Console.WriteLine("X(Const): "+x);
            Console.WriteLine("Y(Const): " + y);
            Console.WriteLine("x1(readonly): "+x1);
            Console.WriteLine("y1(readonly): " + y1);
        }
    }
}
