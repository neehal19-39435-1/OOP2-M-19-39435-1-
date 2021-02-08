using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 100;

            Console.WriteLine("To print all the even numbers");
            Console.WriteLine(" ");

            for (i = 0; i <= n; i++) 
            {
                if (i % 2 == 0)
                    Console.WriteLine("All even numbers printed from 1 to 100 is shown below" +i);
               
            }
            
        }
    }
}
