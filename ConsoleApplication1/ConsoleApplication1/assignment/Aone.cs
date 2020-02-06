using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Aone
    {
        public static void Main(string[] args)
        {
            int Marks;
            

            
            Console.WriteLine("enter marks scored");
            Marks = int.Parse(Console.ReadLine());

            if(Marks<=50)
            {
                Console.WriteLine("failed");
            }
            else if(50<Marks&& Marks<=70)
            {
                Console.WriteLine("satisfactory");
            }
            else if(70<Marks && Marks<=85)
            {
                Console.WriteLine("good");
            }
            else if(85<Marks && Marks<=100)
            {
                Console.WriteLine("excellent");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
