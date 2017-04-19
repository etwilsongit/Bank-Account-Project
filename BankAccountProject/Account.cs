using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
   public class Account //parent class
    {

        //fields
        public string name;
        public int balance;


        //properties
        protected Account()
        {
            this.name = "Jan Hewitt";
            this.balance = 500;
        }

        protected Account(string name, int balance)
        {
            name = "Jan Hewitt";
            balance = 500;
        }




        public void ShowBalance()
        {
            balance;
        }



    }
}
