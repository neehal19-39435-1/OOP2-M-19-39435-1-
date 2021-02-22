using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Account a2 = new Account();
            a1.Accname = "NEEHAL";
            a1.AccID = "280808";
            a1.Balance = 8000;
            Console.WriteLine("Name of Account1 :" +a1.Accname);
            Console.WriteLine("Account ID of Account1 :" +a1.AccID);
            Console.WriteLine("Balance of Account1 :" +a1.Balance);
            a2.Accname = "RAISA";
            a2.AccID = "8028040";
            a2.Balance = 70000;
            Console.WriteLine("Name of Account2 :" + a2.Accname);
            Console.WriteLine("Account ID of Account2 :" + a2.AccID);
            Console.WriteLine("Balance of Account2 :" + a2.Balance);
            a1.Deposit(5000);
            Console.WriteLine("Current balance of Account1 :" + a1.Balance);
            a1.Withdraw(500);
            Console.WriteLine("Current balance of Account1 :" + a1.Balance);
            a1.Transfer(450 , a2);
            Console.WriteLine("Current balance of Account1 :" + a1.Balance);
            Console.WriteLine("Current balance of Account2 :" + a2.Balance);
            Savings s1 = new Savings(a1.Accname , a1.AccID, a1.Balance,500);
            s1.Withdraw(7000, 500);
            Console.WriteLine("Savings account current Balance:" + s1.Balance);
            SpecialCurrent spc1 = new SpecialCurrent(a1.Accname, a1.AccID , a1.Balance, 3500);
            spc1.Withdraw(5000, 1000);
            Console.WriteLine("Cuurent balance of Special current account is: " + spc1.Balance);


        }
    }
}
