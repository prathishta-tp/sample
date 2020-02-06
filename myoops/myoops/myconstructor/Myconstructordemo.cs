using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.myconstructor
{
    class Myconstructordemo
    {
        static void Main(string[] args)
        {
            Student sObj;
            sObj = new Student();//default constructor
            sObj.display();

            Console.WriteLine("");
            sObj = new Student(7, "nitin", 28);//parameterized or overloaded constructor
            sObj.display();

            (new Student()).display();
        }
    }
    class Student
    {
        int iRegNo;
        String sName;
        int iAge;

        public Student()
        {
            iRegNo = 111;
            sName = "noname";
            iAge = 111;
            Console.WriteLine("inside default constructor");
        }

        public Student(int iRegNo,String sName,int iAge)
        {
            this.iRegNo = iRegNo;
            this.sName = sName;
            this.iAge = iAge;
            Console.WriteLine("inside parameter constructor");
        }

        ~Student()
        {
            //do clean here
            Console.WriteLine("destructor");
        }

        public void display()
        {
            Console.WriteLine("regno: "+iRegNo);
            Console.WriteLine("student: "+sName);
            Console.WriteLine("age: "+iAge);
        }
    }
}
