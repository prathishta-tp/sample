using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectiongenerics.Mygenerics
{
    class Employee
    {
        public int no;
        public string name;
        public int age;

        public void display()
        {
            p1(no.ToString());
            p1(name);
            p1(age.ToString());
        }

        void p1(string s)
        {
            Console.WriteLine(s);
        }
    }
}
