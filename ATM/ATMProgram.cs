using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATMProgram
    /*
     
        Greet user when opening program
        Show menu, withdraw, account balance, exit
        
            Withdraw
                Sufficient funds?
                    Yes - release money, change balance
                        back to menu
                    No - Error message, insufficient funds
                        back to menu

            Account balance
                Show account balance
                Go back to menu

            Exit

     */

        //This was done after my calculator script in order to practice the same logic, but with an ATM
    {
        static void Main(string[] args)
        {

            //While true, do/while loop runs
            Boolean bankIsActive = true;

            //holds the balance of user
            int balance = 20000;

            //Menu
            Console.WriteLine("Bank account for Magnus");
            Console.WriteLine("*******************************");
            Console.WriteLine("1: Withdraw");
            Console.WriteLine("2: Show funds");
            Console.WriteLine("3: Exit");

            do
            {
                Console.WriteLine("Choose an option from the menu");
                switch (Console.ReadLine()) {

                    case "1":
                        Console.WriteLine("Enter amount to withdraw");
                        break;
                    //Nested switch case when checking balance
                    //User then recieves two additional jump cases
                    //Either to go back to the menu or leave the program
                    case "2":
                        Console.WriteLine("You currently have "+balance+" kroner in your bank");
                        Console.WriteLine("Press 1 to go back to menu or 2 to exit");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                break;
                            case "2":
                                bankIsActive = false;
                                break;
                        }
                        break;
                    //Exit the program
                    case "3":
                        Console.WriteLine("Exit");
                        bankIsActive = false;
                        break;
                }
            } while (bankIsActive);

        }
    }
}
