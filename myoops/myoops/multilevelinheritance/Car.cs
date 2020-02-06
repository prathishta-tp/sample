using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.multilevelinheritance
{
    class Car:Automobile
    {
        int iNoOfDoors;
        public Car()
        {
            iNoOfDoors = 5;
            iWheels = 4;
            sEngineType = "Petrol/Diesel";
            Console.WriteLine("inside car constructor");
        }

        public override void display()
        {
            Console.WriteLine("no of doors: "+iNoOfDoors);
            base.display();
        }
    }
}
