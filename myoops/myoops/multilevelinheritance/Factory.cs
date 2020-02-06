using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.multilevelinheritance
{
    class Factory
    {
        public static Automobile GetObject(string sCarName)
        {
            if (sCarName.Equals("e1"))
                return new Automobile();
            if (sCarName.Equals("e2"))
                return new Car();
            if (sCarName.Equals("e3"))
                return new NissanMicra();
            return null;//check the failure at run time
          //  return new Bill();//compile time error as return type is automobile
        }
    }
}
