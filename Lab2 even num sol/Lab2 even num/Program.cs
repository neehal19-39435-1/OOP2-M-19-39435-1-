using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 100;

            Console.WriteLine("All even numbers printed from 1 to 100 are shown below");
            Console.WriteLine(" ");

            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)

                    Console.WriteLine(" " + i);

            }

        }
    }
}
