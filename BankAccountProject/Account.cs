using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Account
    {
        protected string firstName;
        protected string lastName;
        protected double balance;

        public string FirstName
        {
            set
            {
                firstName = "Jan";
            }
        }
        public string LastName
        {
            set
            {
                lastName = "Hewitt";
            }
        }
        public double Balance
        {
            set
            {
                balance = 500;
            }
        }
        //public override string ToString()
        //{
        //    return firstName + lastName +
        //}
    }
}
