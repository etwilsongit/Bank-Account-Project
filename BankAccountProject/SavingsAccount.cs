using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : Account
    {


        public void deposit(double amount)
            balance += amount;
        public void withdraw(double amount)
            balance -= amount;
        public void withdraw(double amount)
        {
            if balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Sorry, you do not have the available funds to take out that amount...");
            }



        }
    }
}
