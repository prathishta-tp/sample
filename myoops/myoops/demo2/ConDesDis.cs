using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//constructor,destructor,dispose
namespace myoops.demo2
{
    class ConDesDis
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program for access student class");


            /*    Student objStud;
                objStud = new Student();
                objStud.display();

                objStud.iRegNo = 1;
                objStud.sName = "nitin rao";
                objStud.iAge = 25;
                objStud.display();

                objStud.add(2, "vishwa", 25, 89);
                objStud.display();
               // objStud.Dispose();//this will suppress finalize
               // GC.Collect();//gives more time priority to memeory mgt than for program*/
            createStud();
            Console.WriteLine("end of main");
            Console.ReadKey();
        }

        public static void createStud()
        {
            Console.WriteLine("inside create stud");
            Student s1;
            s1 = new Student();
            s1.display();

            //s1.Dispose();//for user to call
            //s1 = null;//with null and GC.Collect() , it will show the destructor defore function exit
            //GC.Collect();//avoid
            //System.Threading.Thread.Sleep(1000);//to delay your current thread; so that GC takes priority
            //s1.display();
            Console.WriteLine("going out of create stud");
        }
    }
}
