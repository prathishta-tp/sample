using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Aseventeen
    {
        static void Main(string[] args)
        {
            BillingSystem[] sObj;
            sObj = new BillingSystem[6];
            sObj[0] = new BillingSystem();
            sObj[1] = new BillingSystem();

            sObj[0].Save("15/01/2020", "01:20:24:30");
            sObj[1].Save("16/01/2020", "02:05:21:45");
            sObj[0].Display();
            sObj[1].Display();
        }
    }
}
