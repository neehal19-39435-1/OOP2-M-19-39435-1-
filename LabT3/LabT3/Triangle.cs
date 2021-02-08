using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabT3
{
    public class Triangle
    {
        public int x, y, z;
        public Triangle(int x , int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
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
