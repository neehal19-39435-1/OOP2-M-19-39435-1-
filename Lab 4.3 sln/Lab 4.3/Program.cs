using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //int sum = 0;
            int[] arr = new int[] { 2, 4, 6, 8, 10 };
            int size = arr.Length;
            int[] arr1 = new int[size]; 


            Console.WriteLine("Array values : ");

            for (i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(" " + arr[i]);
            }
            Console.WriteLine("Copied array:");

            for (i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
                Console.WriteLine(" " + arr1[i]);

            }
           
        }
    }
}
