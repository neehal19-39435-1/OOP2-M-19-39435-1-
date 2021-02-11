using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabT3
{
    class Account
    {
        string AccName, AccId;
        int balance;
        

        public Account(string AccName , string AccId, int balance )
        {       
            this.AccName = AccName;
            this.AccId = AccId;
            this.balance = balance;
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
    }
}
