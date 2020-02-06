using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.fiesrtdemo
{
    class Student
    {
        //member variables
        public int ID;
        public string Name;
        public string City;
        public int mCount;

        //class variable
        public static int count;

        //constructor
        public Student ()
        {
            count++;
            mCount++;
        }

        //member function
        public bool save(int id, string name,string city)
        {
            ID = id;
            Name = name;
            City = city;

            return true;
        }

        public bool get(int id, ref string name, ref string city)
        {
            if(ID==id)
            {
                name = Name;
                city = City;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void display()
        {
            Console.WriteLine("ID:"+ID);
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("City:"+City);
            Console.WriteLine("count:"+count);//static variable
            Console.WriteLine("mCount:"+mCount);
        }

        //class method
        public static void displaycount()
        {
            Console.WriteLine("student count:"+count);
           // Console.WriteLine("ID:"+ID);//error
        }
    }
}
