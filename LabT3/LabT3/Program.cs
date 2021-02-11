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
            Student obj1 = new Student("NEEHAL", "19-1", "CIS", 3.5f);
            obj1.ShowInfo();
            Console.WriteLine(" ");
            Console.WriteLine("TRIANGLE INFO:");
            Triangle obj2 = new Triangle(20, 20, 20);
            obj2.ShowInfo();
            obj2.TestTriangle();
            Console.WriteLine(" ");
            Console.WriteLine("COURSE INFO:");
            Course obj3 = new Course("OOP2", "CSC3115", 3);
            obj3.ShowInfo1();
            Console.WriteLine(" ");
            Console.WriteLine("ACCOUNT INFO:");
            Account obj4 = new Account("NEEHAL", "28089", 100000);
            obj4.Deposit(1000);
            obj4.Withdraw(1000);
            
        }
    }
}

