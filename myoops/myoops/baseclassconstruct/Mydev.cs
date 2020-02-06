using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.baseclassconstruct
{
    class Mydev:Mybase
    {
        int iZ;

        public Mydev() : base("dotnet bond")
        {
            iZ = 15;
            Console.WriteLine("inside Mydev constructor");
        }

        public Mydev(String s) 
        {
            //will call default base constructor
            Console.WriteLine("inside mydev constructor with parameter");
        }

        public void devDisplay()
        {
            Console.WriteLine("\n devDisplay function");
            Console.WriteLine("value of iZ: "+iZ);
            baseDisplay();
        }
    }
}
