using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.general
{
    class MyTypeCast
    {
        static void Main(string[] args)
        {
            byte bx;
            short sy;
            int iz;

            sy = 255;//sy=256;//byte limit is only 255, puts junk value
            iz = sy;
            Console.WriteLine("value of z: "+iz);
            //bx = sy;//this will not work
            bx = (byte)sy;//(type casting)
            //using "as" operator to do type same conversion
            //"as" works on reference type or nullable types only
            //bx=sy as byte;//complication error
            Console.WriteLine("value of x: "+bx); 
        }
    }
}
