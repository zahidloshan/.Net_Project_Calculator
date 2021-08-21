using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            OpeningDate date1 = new OpeningDate(27,"july",2020);
            CurrentAccount ca = new CurrentAccount("Zahid Hasan", 4563858, date1, 8000, "personal");
            
            ca.AccountInfo();
            ca.Deposit(2000);
            Console.WriteLine("New Balance :{0}",ca.Balance);
            ca.Withdraw(2000);
            Console.WriteLine("New Balance :{0}",ca.Balance);
            ca.Withdraw(500);
            Console.WriteLine("New Balance :{0}", ca.Balance);
            ca.Withdraw(100);
            Console.WriteLine("New Balance :{0}", ca.Balance);


            OpeningDate date2 = new OpeningDate(10, "may", 2010);
            SavingsAccount sa = new SavingsAccount("Mahedi Hasan", 7893858, date2,7000,5);
            sa.AccountInfo();
            sa.Deposit(2000);
            Console.WriteLine("New Balance :{0}", sa.Balance);
            sa.Deposit(4000);
            Console.WriteLine("New Balance :{0}", sa.Balance);
            sa.Deposit(3000);
            Console.WriteLine("New Balance :{0}", sa.Balance);
            sa.Withdraw(500);
            Console.WriteLine("New Balance :{0}", sa.Balance);
            sa.Withdraw(2000);
            Console.WriteLine("New Balance :{0}", sa.Balance);
        }
    }
}
