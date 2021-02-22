using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Fixed : Account 
    {
         private int tenureYear;
         private int currentYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }

        public int CurrentYear
        {
            get { return tenureYear; }
            set { tenureYear = value;}
        }

        public Fixed(string accName,string acId, int balance, int minBalance)
        {
            this.Accname = accName;
            this.AccID = acId;
            this.Balance = balance;
            this.tenureYear = tenureYear;
            this.CurrentYear = currentYear;
        }

        public void Withdraw(int currentYear , int tenureYear , int amount)
        {
            if (tenureYear < currentYear)
            {
                if (amount < Balance)
                {
                    this.Balance -= amount;
                    Console.WriteLine("Balance after withdrawing amount:" + this.Balance);
                }

                else
                {
                    Console.WriteLine(" There is an insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Transaction is not possible because it has not crossed tenure year ");
            }


        }
    }
}
