using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectiongenerics.Mygenerics
{
    class Client
    {
        static void Main(string[] args)
        {
            int x, y, z;
            double d1, d2, d3;
            //x = 10;
            //y = 20;
            //d1 = 45.8;
            //d2 = 67.9;

            /* //normal class
             NormalClass nc = new NormalClass();
             Console.WriteLine("number interchange with normal class");
             Console.WriteLine("x:{0} y:{1}",x,y);
             nc.interchange(ref x, ref y);
             Console.WriteLine("x:{0} y:{1}", x, y);
             */

            /* //error because of double
             Console.WriteLine("d1:{0} d2:{1}",d1,d2);
             nc.interchange(ref d1, ref d2);
             Console.WriteLine("d1:{0} d2:{1}", d1, d2);
             */

            //with generic method
            WithGenericMethod wgm = new WithGenericMethod();
          /*  x = 25;
            y = 50;
            Console.WriteLine("\n generics works with int");
            Console.WriteLine("x:{0} y:{1}", x, y);
            wgm.interchange<int>(ref x, ref y);
            wgm.interchange(ref x, ref y);
            Console.WriteLine("x:{0} y:{1}\n\n", x, y);


            Console.WriteLine("\n generics works with double");
            d1 = 56.8;
            d2 = 55.9;
            Console.WriteLine("d1:{0} d2:{1}", d1, d2);
            wgm.interchange<double>(ref d1, ref d2);

            Console.WriteLine("d1:{0} d2:{1}\n\n", d1, d2);
            */
            Employee e1, e2;
            e1 = new Employee();
            e2 = new Employee();
            e1.no = 1;
            e1.name = "isha";
            e1.age = 22;

            e2.no = 2;
            e2.name = "ishaaaaaaaaaaaa";
            e2.age = 23;

            Console.WriteLine("before interchange\n");
            e1.display();
            e2.display();

            wgm.interchange<Employee>(ref e1, ref e2);
            //below also works
            //wgm.interchange(ref e1, ref e2);
            Console.WriteLine("after interchange");
            e1.display();
            e2.display();
            
        }
    }
}
