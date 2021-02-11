using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, even_sum=0 , odd_sum=0 ;


            for ( i =1 ; i <=100 ; i++)
            {
                if (i % 2 == 0)
                    even_sum = even_sum +  i;
                else 
                odd_sum = odd_sum + i; 
                
            }

            Console.WriteLine("Sum of all even numbers :" + even_sum);
            Console.WriteLine("Sum of all odd numbers :" + odd_sum);

        }
    }
}
