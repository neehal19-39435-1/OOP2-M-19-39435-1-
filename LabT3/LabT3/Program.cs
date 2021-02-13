using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STUDENT INFO: ");
            Student obj1 = new Student();
            obj1.Name = "Neehal";
            obj1.ID = "19-1";
            obj1.Dept = "CIS";
            obj1.CGPA = 3.5f;
            obj1.ShowInfo();

            Console.WriteLine(" ");

            Console.WriteLine("TRIANGLE INFO:");
            Triangle obj2 = new Triangle();
            obj2.X = 30;
            obj2.Y = 30;
            obj2.Z = 30;
            obj2.ShowInfo();
            obj2.TestTriangle();

            Console.WriteLine(" ");

            Console.WriteLine("COURSE INFO:");
            Course obj3 = new Course();
            obj3.coursename = "OOP2";
            obj3.coursecode = "CSC3510";
            obj3.coursecredit = 3;
            obj3.ShowInfo();

            Console.WriteLine(" ");

            Console.WriteLine("ACCOUNT INFO:");
            Account obj4 = new Account();
            obj4.Accname = "Neehal";
            obj4.AccID = "2808nr";
            obj4.Balance = 100000;
            obj4.Deposit(1000);
            obj4.Withdraw(1000);
            
        }
    }
}

