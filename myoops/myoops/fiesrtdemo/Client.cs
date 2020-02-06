using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.fiesrtdemo
{
    class Client
    {
        public static void Main(string[] args)
        {
            // SimpleStudent();
            Student[] sObj;//4 bytes
            sObj = new Student[5];//20 bytes
            sObj[0] = new Student()
            {
                ID = 1,
                Name = "isha",
                City = "mangalore"
            };
            // Student.displaycount();
            Console.WriteLine("no. of students[1]:" + Student.count);
            sObj[1] = new Student();
            Console.WriteLine("no. of students[1]:"+Student.count);
            sObj[1].ID = 2;
            sObj[1].Name = "sanmathi";
            sObj[1].City = "mangalore";
            sObj[2] = new Student()
            {
                ID = 3,
                Name = "ajay",
                City = "delhi"
            };
            Console.WriteLine("no. of students[2]:"+Student.count);

            sObj[3] = new Student()
            {
                ID = 4,
                Name = "tejpal",
                City = "delhi"
            };
            Console.WriteLine("no. of students[3]:" + Student.count);
            sObj[4] = new Student()
            {
                ID = 5,
                Name = "shobha",
                City = "bangalore"
            };
            Console.WriteLine("no. of students[4]:" + Student.count);
            sObj[0].display();
            sObj[1].display();
            sObj[2].display();
            sObj[3].display();
            sObj[4].display();

        }
            private static void SimpleStudent()
        {
            Student sObj;//4 bytes
            sObj = new Student();//size of variable in student
            bool Status;
            Status = sObj.save(1, "isha", "mangalore");
            Console.WriteLine("student saved status" + Status);

            string na = "", ct = "";
            Status = sObj.get(2, ref na, ref ct);
            if (Status)
            {
                Console.WriteLine("record found");
                Console.WriteLine("name | city");
                Console.WriteLine(na + "  |  " + ct);
            }
            else
                Console.WriteLine("record not found");
        } 
    }
            
        }
        
    

