using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Aeleven
    {
        static void Main(string[] args)
        {
            int M;
            Console.Write("Enter divisible by : ");
            M = int.Parse(Console.ReadLine());

            Console.WriteLine("count= "+countdivisible(M));

        }

        static int countdivisible(int M)
        {
            int[] array = new int[10];
            array[0] = 1;
            array[1] = 2;
            array[2] = 5;
            array[3] = 12;
            array[4] = 15;
            array[5] = 18;
            array[6] = 20;
            array[7] = 22;
            array[8] = 25;
            array[9] = 28;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % M == 0)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
