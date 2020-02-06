using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Aseven
    {
        // Function to count the numbers divisible by 
        // M in a given range 
        static int countDivisibles(int A, int B, int M)
        {
            // Variable to store the counter 
            int counter = 0;

            // Running a loop from A to B and check 
            // if a number is divisible by M. 
            for (int i = A; i <= B; i++)
                if (i % M == 0)
                    counter++;

            return counter;
        }

        static void Main(string[] args)
        {
            //int count;
            // A and B define the range, M is the dividend 
            int A , B , M ;
            Console.Write("Enter the Limit : ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            Console.Write("Enter divisible by : ");
            M = int.Parse(Console.ReadLine());
            // Printing the result 
            Console.WriteLine("count  is:    "+countDivisibles(A, B, M));


           
        }
    }
}
