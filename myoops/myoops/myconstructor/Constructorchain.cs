using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.myconstructor
{
    class Constructorchain
    {
        static void Main(string[] args)
        {
            Employee eObj;
            eObj = new Employee(); //default constructor
            eObj.display();

            Console.WriteLine("");
            eObj = new Employee(7, "nitin", 28); //overloaded constructor
            eObj.display();

            Console.WriteLine("");
            eObj = new Employee(8, "tanvir");//overloaded chain constructor
            eObj.display();
        }
    }
    class Employee
    {
        int iEmpNo;
        String eName;
        int iAge;

        public Employee()
        {
            iEmpNo = 111;
            eName = "noname";
            iAge = 111;
            Console.WriteLine("inside default constructor");
        }

        //chained constructor
        public Employee(int iEmpNo,String eName):this(iEmpNo,eName,18)
        {
            Console.WriteLine("inside 2 parameter constructor ");
        }

        public Employee(int iEmpNo,String eName,int iAge)
        {
            this.iEmpNo = iEmpNo;
            this.eName = eName;
            this.iAge = iAge;
            Console.WriteLine("inside 3 parameter constructor");
        }

        ~Employee()
        {
            //do clean here
            Console.WriteLine("destructor");
        }

        public void display()
        {
            Console.WriteLine("emp no: "+iEmpNo);
            Console.WriteLine("student: "+eName);
            Console.WriteLine("age: "+iAge);
        }
    }
}
