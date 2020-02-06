using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.baseclassconstruct
{
    class Client
    {
        static void Main(string[] args)
        {
            Mydev md;
           md = new Mydev();
            //md = new Mydev("new dotnet bond");//will call default base class constructor
            md.devDisplay();
           // md.baseDisplay();//this is also possible
        }
    }
}
