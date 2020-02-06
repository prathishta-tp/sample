using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class BillingSystem
    {
        public string Billdate, Billtime;
        //class variable
        public static string Companyname = "SLK Software";
        public static string Address;
        public BillingSystem ()
        {
            Address = "Bangalore";

        }
        public void Save(string billdate,string billtime)
        {
            Billdate = billdate;
            Billtime = billtime;
        }

        public void Display()
        {
            Console.WriteLine("companyname: "+Companyname);
            Console.WriteLine("address: "+Address);//static variable
            Console.WriteLine("billdate: "+Billdate);
            Console.WriteLine("billtime: "+Billtime);
        }
    }
}
