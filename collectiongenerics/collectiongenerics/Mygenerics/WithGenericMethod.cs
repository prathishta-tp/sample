using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectiongenerics.Mygenerics
{
    class WithGenericMethod//:iCalculator
    {
        public void interchange<T>(ref T x,ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
}
