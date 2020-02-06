using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//constructor,destructor,dispose
namespace myoops.demo2
{
    class Student
    {
        //MEMBER VARIABLES
        public int iRegNo;//=ch();//not posiible as this an instance function
        public String sName;//="isha";//possible
        public int iAge;
        public int iMarks;

        //constructor
        public Student()
        {
            //do your ini here
            iRegNo = ch();//iRegNo = ch();//cannot be done outside a function
            sName = "ravi";
            iAge = 22;
            iMarks = 77;
            Console.WriteLine("inside constructor");
        }

        //destructors
        ~Student()
        {
            //do your clean up here
            Console.WriteLine("inside destructors");
        }

        public void Dispose()
        {
            //to be called by client class for clearing unmanaged code objects
            Console.WriteLine("inside dispose method");
            GC.SuppressFinalize(this); 
        }

        public int ch()
        {
            return 10;
        }

        //member functions
        public void display()
        {
            Console.WriteLine("regno: "+iRegNo);
            Console.WriteLine("student: "+sName);
            Console.WriteLine("age: "+iAge);
            Console.WriteLine("marks: "+iMarks);
            displayGrade(iMarks);
            Console.WriteLine("");
        }

        public int add(int iRN,String sN, int iA,int iM)
        {
            iRegNo = iRN;
            sName = sN;
            iAge = iA;
            iMarks = iM;
            return 1;
        }

        public void displayGrade(int iMks)
        {
            if (iMks>90)
                Console.WriteLine("A grade");
            else if(iMks>80)
                Console.WriteLine("B grade");
            else if(iMks<50)
                Console.WriteLine("not cleared");
        }
    }
}
