using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double phy, chem, bio, comp, math, total;
            double percentage;
            string name, id;

            Console.WriteLine("Calculating the total percentage and grade of the student:");
            Console.WriteLine(" ");

            Console.WriteLine("Enter the name of the student:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the ID:");
            id = Console.ReadLine();
            Console.WriteLine("Enter the mark of physics:");
            phy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the mark of chemistry:");
            chem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the marks of biology");
            bio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the mark of computer science");
            comp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enetr the marks of mathematics");
            math = Convert.ToDouble(Console.ReadLine());

            total = phy + chem + bio + comp + math;
            percentage = total / 5.0; 

            if (percentage >= 90)
            {
                Console.WriteLine("Grade is A+");
            }
            else
                if(percentage <=89 && percentage >=85)
                {
                    Console.WriteLine("Grade is A");
                }
             else
                if (percentage <=85 && percentage >=80)
                {
                    Console.WriteLine("Grade is B+");
                }
             else
                if(percentage <=79 && percentage >=75)
                {
                    Console.WriteLine("Grade is B");
                }
             else 
                if(percentage <=75 && percentage >=50)
                {
                    Console.WriteLine("Grade is C+");
                }
             else
                if(percentage < 50)
                {
                    Console.WriteLine("Grade is F");
                }
            Console.WriteLine("Total percentage is :" + percentage);
        }
    }
}
