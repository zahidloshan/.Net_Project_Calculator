using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    struct OpeningDate
    {
        private byte day;
        private string month;
        private ushort year;

        public OpeningDate(byte day, string month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
   
        }


        public void ShowDate()
        {
            Console.WriteLine("Opening Date:  {0}:{1}:{2}", this.day, this.month, this.year);

        }

    }

    internal class Account
    {
        private string holderName;
        private uint id;
        private OpeningDate date;
        private uint balance;

        internal string HolderName
        {
            get { return this.holderName; }
            set { this.holderName = value; }
        }

        internal uint Id
        {
            get { return this.id; }
            set { this.id = value; }
        }


        internal OpeningDate Date
        {
            get { return this.date; }
            set { this.date = value; }
        }


        internal uint Balance
        {
            get { return this.balance; }
            set { this.balance= value; }
        }

        internal Account(string holderName,uint id,OpeningDate date,uint balance)
        {
            this.HolderName = holderName;
            this.Id = id;
            this.Date = date;
            this.Balance = balance;
             
        }


        internal virtual void AccountInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Account Information");
            Console.WriteLine("Account Holder : {0}", this.HolderName);
            Console.WriteLine("Id :{0} ",this.Id);
            Console.WriteLine("Balance : {0} ",this.Balance);
            this.Date.ShowDate();
        }


        

        
    }
}
