using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myoops.hidingmethod
{
    class Client
    {
        static void Main(string[] args)
        {
            //Mydev1 md1;
            //md1 = new Mydev1();
            //md1.display();

            Mybase mb1;
           // mb1 = new Mybase();
            mb1 =new Mydev1();
            mb1.display();//will call base class function
        }
    }
}
