using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class q24
    {
        static void Main(string[] args)
        {
            Astudent24 st = new Astudent24();
            st.ReadDetails();
            st.DisplayDetails();
        }
    }
    class Astudent24
    {
        string name,subid;
        int age;
        double fees;
        public void ReadDetails()
        {
            Console.WriteLine("enter name");
            name= Console.ReadLine();
            Console.WriteLine("enter age");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter fees");
            fees = double.Parse(Console.ReadLine());
            Console.WriteLine("enter subid");
            subid = Console.ReadLine();
        }

        public void DisplayDetails()
        {
            Console.WriteLine("name:"+name);
            DisplayDetails(age);
        }
        public void DisplayDetails(int age)
        {
            Console.WriteLine("age:" + age);
            DisplayDetails(fees, subid);
        }
        public void DisplayDetails(double fees,string subid)
        {
            //Console.WriteLine("fees:" + fees+"\t"+"subid:"+subid);
            Console.WriteLine("fees:{0}\t subid:{1}",fees,subid);
        }
    }
}
