using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Account
    {
        private string AccName, AccId;
        private int balance;


        public string Accname
        {
            get { return AccName; }
            set { AccName = value; }
        }

        public string AccID
        {
            get { return AccId; }
            set { AccId = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine("Balance after depositing amount:" + this.balance);
            }

        }

        public void Withdraw(int amount)
        {
            if (amount < balance)
            {
                this.balance -= amount;
                Console.WriteLine("Balance after withdrawing amount:" + this.balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

            public void Transfer(int amount, Account acc)
            {
                acc.balance = acc.balance + amount;
                this.balance = this.balance - amount;
            }
        
    }
}