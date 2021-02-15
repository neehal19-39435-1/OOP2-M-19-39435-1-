using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i;
            int sum = 0;
            int[] arr = new int [] { 2, 4, 6, 8, 10 };
            
            
            Console.WriteLine("Array values : ");

            for ( i = 0; i < arr.Length; i++ )
            {
                
                Console.WriteLine(" " + arr[i]);
            }

            for ( i = 0 ; i < arr.Length ; i++)
            {
                sum = sum + arr[i];
                
            }
            Console.WriteLine("Sum of all elements in the array is " + sum);
            
        }
    }
}
