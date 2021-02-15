using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To print the given array in the reverse order");

            //int i;
            int n = 5;
            int [] arr = new int[n];

            Console.WriteLine("Array is:");

            for (int i = 0 ; i < n ; i++)
            {
                arr[i] = i;
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Reversed array is:");

            for (int i = n-1 ; i>=0 ; i-- )
            {
                arr[i] = i;
                Console.Write(" " + arr[i]);
            }

            Console.WriteLine(" ");

        }
    }
}
