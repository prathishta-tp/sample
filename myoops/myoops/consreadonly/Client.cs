using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.consreadonly
{
    class Client
    {
        static void Main(string[] args)


        {
            Taskbar tb;
            //tb = new Taskbar();
            tb = new Taskbar(40, 45);
            tb.display();
        }
    }
}


