using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal class SavingsAccount:Account
    {
        private byte duration;
        internal byte Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

         internal SavingsAccount(string holderName,uint id,OpeningDate date,uint balance,byte duration) :base(holderName,id,date,balance)
        {
           this.Duration=duration;  
        }

        internal override void AccountInfo()
        {
            base.AccountInfo();
            Console.WriteLine("Duration : {0} years", this.Duration);

        }

        internal void Withdraw(uint money)
        {
            uint newBalance = this.Balance - money;

            if (newBalance < 0)
            {
                Console.WriteLine("Your Balance Less than 0");
            }
            else
            {

                this.Balance = this.Balance - money;

            }

        }
		internal void Deposit(uint money)
        {
            if (money < 500)
            {
                Console.WriteLine("Must deposit at least 500 taka.");
            }
            else {
                this.Balance = this.Balance + money;
            }

            
        }
    }
}
