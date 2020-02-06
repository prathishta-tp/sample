using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//static polymorphism/compile-time polymorphism
namespace myoops.demo2
{
    class Staticpolymorphism
    {
        static void Main(string[] args)
        {
            double z;
            //z = sum(15, 12);//polymorphic function call
           // z = sum("hello", "mars");//polymorphic function call compilation error(static/compile time poly)
           // z = sum(15.7, 12.3);//polymorphic function call to double,double
           // z = sum(0.2223F, 0.2223F);//polymorphic function call to FLOAT,FLOAT
            Console.WriteLine();
        }


        public static float sum(float x,float y)
        {
            Console.WriteLine("inside float,float");
            return x + y;
        }


        public static int sum(int x,int y)
        {
            Console.WriteLine("inside int,int");
            return x + y;
        }
    }
}
