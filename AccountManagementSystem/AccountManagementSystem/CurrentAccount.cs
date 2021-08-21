using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal class CurrentAccount:Account
    {
        private string accountType;

        internal string AccountType
        {
            get { return this.accountType; }
            set { this.accountType= value; }
        }

        internal override void AccountInfo()
        {
            base.AccountInfo();
            Console.WriteLine("Account Type : {0} ", this.AccountType);

        }

        internal CurrentAccount(string holderName,uint id,OpeningDate date,uint balance,string accountType) :base(holderName,id,date,balance)
        {
           this.AccountType=accountType;  
        }

        internal void Withdraw(uint money)
        {
            uint newBalance=this.Balance-money;

            if (newBalance < 500)
            {
                Console.WriteLine("Maintain at least a balance of 500 taka even after any withdrawal");

            }
            else {

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
