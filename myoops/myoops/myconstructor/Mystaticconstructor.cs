using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.myconstructor
{
    class Mystaticconstructor
    {
        static void Main(string[] args)
        {
            Circle.display(); //calls static constructor
            Circle c;
            Console.WriteLine("before new");
            c = new Circle();//calls normal constructor
            c.mydisplay();//calls instance constructor

            Circle.display();
        }
    }

    class Circle
    {
        public static int x;
        public static int y;

        static Circle() //gets called only once
        {
            x = 2;
            y = 2;
            Console.WriteLine("in static constructor");
        }

        public Circle() //gets called every time new is used
        {
            x = 5;
            y = 5;
            Console.WriteLine("in instance constructor");
        }

        public static void display()
        {
            Console.WriteLine("x: "+x+ "y: "+y);

        }

        public void mydisplay()
        {
            Console.WriteLine("x: "+x+"y: "+y);
        }
    }
}
