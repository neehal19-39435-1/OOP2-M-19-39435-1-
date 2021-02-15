using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 1, 2, 4, 5, 5, 5, 5, 8, 9 };
            int i, j, count = 0;
            Console.WriteLine("Array values:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
                
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            
            for (i=0 ; i<arr.Length; i++)
            {
                for(j=i+1 ; j< arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        count++;
                        break;
                    }

                }
            }
            Console.WriteLine("Duplicate array values:" +count);
        }
    }
}
