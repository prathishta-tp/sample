using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.mynesteddemo
{
    class Student
    {
        #region variable declaration
        private int iRegNo;
        private String sName;
        private int iAge;
        public Semester semObj;
        #endregion

        public Student()
        {
            iRegNo = 111;
            sName = "noname";
            iAge = 23;
            Console.WriteLine("inside student constructor");
        }

        public void Display()
        {
            Console.WriteLine("regno: "+iRegNo);
            Console.WriteLine("student: "+sName);
            Console.WriteLine("age: "+iAge);

            if (semObj != null)
                semObj.Display();
            
        }

        public void Save(int iRegNo, string sName,int iAge,int Topic1,int Topic2)
        {
            this.iRegNo = iRegNo;
            this.sName = sName;
            this.iAge = iAge;

            if((Topic1+Topic2)>0)
            {
                semObj = new Semester(this);
                semObj.Topic1 = Topic1;
                semObj.Topic2 = Topic2;
            }
        }

        public class Semester
        {
            public int Topic1;
            public int Topic2;
            
            public Semester()
            {
                Console.WriteLine("inside semester constructor");
            }

            
            private Student Parent;//member variable

            public Semester(Student Parent)
            {
                Console.WriteLine("inside semester parameterized constructor");
                this.Parent = Parent;
            }

            public void Display()
            {
                //accessing private members of the parent class
                if(Parent!=null)
                    Console.WriteLine("parent.regno: "+Parent.iRegNo);

                Console.WriteLine("topic1: "+Topic1);
                Console.WriteLine("topic2: "+Topic2);
            }
                


        }
    }
}
