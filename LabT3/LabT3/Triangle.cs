using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabT3
{
    public class Triangle
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set {x =  value;}
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

       

        public void ShowInfo()
        {
            Console.WriteLine("The length of the first edge:" + x);
            Console.WriteLine("The length of the second edge:" + y);
            Console.WriteLine("The length of the third edge:" + z);
        }
        
        public void TestTriangle()
        {
            if (x == y && y == z && x == z )

                Console.WriteLine("This is an Equilateral Triangle");

            else if (x == y || y == z || z == x)
                Console.WriteLine("This is an Isosceles Triangle");
            else
                Console.WriteLine("This is a Scalene Triangle");
        }
    }
}
