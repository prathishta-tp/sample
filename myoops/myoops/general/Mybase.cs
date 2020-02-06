using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.general
{
    class Mybase
    {
        private int ix;
        private String sy;
        public Mybase()
        {
            ix = 5;
            sy = "bond";
            Console.WriteLine("inside mybase constructor");
        }
        void defaultDisplay()
        {
            //only current class can use it;by default private
            Console.WriteLine("default display function(private)");
            Console.WriteLine("value of ix: "+ix);
            Console.WriteLine("value of sy: "+sy);
        }
        public void pubDisplay()
        {
            //any class can can use this method using object of this class
            Console.WriteLine("\n public display function");
            Console.WriteLine("value of ix: "+ix);
            Console.WriteLine("value of sy: "+sy);
        }
        private void pvtDisplay()
        {
            //only current class can use this method
            Console.WriteLine("\n private display function");
            Console.WriteLine("value of ix: "+ix);
            Console.WriteLine("value of sy: "+sy);
        }
        protected void prtDisplay()
        {
            Console.WriteLine("\n protected display function");
            Console.WriteLine("value of ix: " + ix);
            Console.WriteLine("value of sy: " + sy);
        }
        internal void intDisplay()
        {
            Console.WriteLine("\n internal display function");
        }
        protected internal void piDisplay()
        {
            //any class can use this method using object of this class
            //within a package
            //class in another package can use this method only when it inherits
            Console.WriteLine("\n protected internal display function");
        }
    }
}
