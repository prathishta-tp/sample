using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.multilevelinheritance
{
    class Automobile
    {
        public int iWheels;
        public String sEngineType;

        public Automobile()
        {
            iWheels = 2;
            sEngineType = "Petrol";
            Console.WriteLine("inside automobile constructor");
        }

        public virtual void display()
        {
            Console.WriteLine("no of wheels: "+iWheels);
            Console.WriteLine("EngineType: "+sEngineType);
        }
    }
}
