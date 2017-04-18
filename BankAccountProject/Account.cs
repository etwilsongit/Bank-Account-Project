using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Account //parent class
    {

        //fields
        private string name;
        private int balance;


        //properties
        protected Account()
        {
            this.name = "Jan Hewitt";
            this.balance = 500;
        }

        protected Account(int balance)
        {
            
        }

    }
}
