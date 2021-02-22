using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class OverDraft : Account
    {
         private int limit;

        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        public OverDraft(string accName,string acId, int balance, int minBalance)
        {
            this.Accname = accName;
            this.AccID = acId;
            this.Balance = balance;
            this.limit = limit;
        }

        public void Withdraw(int amount, int limit)
        {
            if (amount <= (limit + Balance))
            {
                if (amount < Balance)
                {
                    this.Balance -= amount;
                    Console.WriteLine("Balance after withdrawing amount:" + this.Balance);
                }

                else
                {
                    int val = (Balance + limit) - amount;
                    Console.WriteLine(" There is an insufficient balance in your account. Only " + val+ " limit left");
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance ");
            }
        }
    }
}
