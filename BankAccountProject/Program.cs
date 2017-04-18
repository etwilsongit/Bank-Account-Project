using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiating Jan's bank account
            //Account janAccount = new Account();


            //greet Jan when she opens the program 
            //fun fact: 'Rolyat' is just 'Taylor' backwards, which is my middle name
            Console.WriteLine();
            Console.WriteLine("<Welcome, Jan, to your Rolyat Bank Account>");
            Console.WriteLine();


            int menuOptions;

            do
            {
                //these are the options Jan will see upon starting the program
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****** MENU ******");
            Console.WriteLine("1. View Client Information"); //
            Console.WriteLine("2. View Account Balance"); //
            Console.WriteLine("3. Deposit Funds"); //
            Console.WriteLine("4. Withdraw Funds"); //
            Console.WriteLine("5. Exit"); //Ends the program
            Console.WriteLine();



                menuOptions = int.Parse(Console.ReadLine());

                //    janAccount.ClientAccountStatus();

                switch (menuOptions)
                {
                    //        //when the user selects options, these switch cases change the stats
                        case 1:
                                Console.WriteLine();
                                Console.WriteLine("<Client Information>");
                                Console.WriteLine("-Name: \t\t\t\t\t Jan Hewitt");
                                Console.WriteLine("-Savings Account Number: \t\t 11223344");
                                Console.WriteLine("-Checking Account Number: \t\t 11223344");
                                Console.WriteLine("-Routing Number: \t\t\t 009876123");
                                Console.WriteLine("-Card Number: \t\t\t\t 4558169378384243");
                                Console.WriteLine("-Bank Name: \t\t\t\t Rolyat Bank");
                                Console.WriteLine("-Phone Number: \t\t\t\t 555-0199");
                                Console.WriteLine("-Address: \t\t\t\t 1234 Wood Way");
                                Console.WriteLine("-Username: \t\t\t\t JanHewitt1895");
                                Console.WriteLine("-Password Hint: \t\t\t \"What was the name of your first pet?\"");
                                break;
                        //case 2:

                        //            janAccount.ShowBalance();
                        //            Console.WriteLine("Your current balance is" + Balance);
                        //            break;
                        //        case 3:

                        //            janAccount.BalanceIncrease();
                        //            Console.WriteLine("");
                        //            break;
                        //        case 4:

                        //            janAccount.BalanceDecrease();
                        //            Console.WriteLine("");
                        //            break;
                        //        default:

                        //            Console.WriteLine("Yikes! You chose to do nothing with that invalid option...");
                        //            break;
                }




            } while (menuOptions != 5) ;

            }
    }
}
