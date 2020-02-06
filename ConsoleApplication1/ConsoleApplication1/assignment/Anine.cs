using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Anine
    {
        static int remainder(int num, int divisor)
        {
            return (num % divisor);
        }

        static int quotient(int num1, int divisor1)
        {
            return (num1 / divisor1);
        }
        //-------------OR----------------------
        //static int quotient(int num, int divisor)
        //{
        //    return (num / divisor);
        //}

        public static void Main()
        {
            Console.WriteLine("quotient= "+quotient (15, 7));
            //Console.WriteLine("quotient= "+quotient (100, 7));
            Console.WriteLine("remainder= "+remainder(100, 7));
        }
    }
}
