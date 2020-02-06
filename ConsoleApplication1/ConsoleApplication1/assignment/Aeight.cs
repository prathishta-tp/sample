using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.assignment
{
    class Aeight
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            array[0] = 2;
            array[1] = 4;
            array[2] = 6;
            array[3] = 8;
            array[4] = 10;
            array[5] = 12;
            array[6] = 14;
            array[7] = 16;
            array[8] = 18;
            array[9] = 20;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array["+i+"}= "+array[i]);
            }
        }
    }
}
