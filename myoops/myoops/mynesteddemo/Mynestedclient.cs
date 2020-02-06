using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.mynesteddemo
{
    class Mynestedclient
    {
        static void Main(string[] args)
        {
            /*Student sObj;
            sObj = new Student();//size is for 3 variable
            Console.WriteLine("without marks");
            sObj.Display();
            Console.WriteLine("\nwith marks");
            //sObj.Save(21, "nitin", 24, 55, 66);//size will increase bt 2 variables
            sObj.Display();
            return;

            Console.WriteLine("\n marks through student");
            //using semester object through student as it is public
            sObj.semObj.Display();*/

            //or

            //using semester class directly as it is public
            Student.Semester marksObj;
            marksObj = new Student.Semester();
            marksObj.Topic1 = 77;
            marksObj.Topic2 = 87;
            Console.WriteLine("\n marks without student");
            marksObj.Display();
        }
    }
}
