using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class SpecialCurrent : Account
    {
         private int openingBalance;

        public int OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }
        }

        public SpecialCurrent(string accName,string acId, int balance, int minBalance)
        {
            this.Accname = accName;
            this.AccID = acId;
            this.Balance = balance;
            this.openingBalance = openingBalance;
        }

        public void Withdraw(int amount, int minBalance)
        {
            if ( amount > minBalance)
            {
                this.Balance -= amount;
                Console.WriteLine("Balance after withdrawing amount:" + this.Balance);
            }
            else
            {
                Console.WriteLine(" There is an insufficient balance");
            }
        }
    }
}
