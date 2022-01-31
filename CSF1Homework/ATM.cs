using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.Title = "ATM";
            bool doAnother = false;
            bool isUser = false;
            bool isUserPin = false;
            decimal accountBalance = 10000;
            int loginAttempts = 0;
            int passwordAttempts = 0;


            do
            {
                for (int i = 1; i < 3; i++)
                {
                    Console.Write("Welcome to First Operational Bank\nPlease enter your account number:(You have 3 tries) ");
                    string userAccountNumber = Console.ReadLine();

                    if (userAccountNumber == "12345")
                    {
                        isUser = true;
                    }


                    if (isUser)
                    {
                        Console.WriteLine("Please enter your PIN: ");
                        string userPin = Console.ReadLine();
                        if (userPin == "1111")
                        {
                            isUserPin = true;
                        }
                        if (isUserPin)
                        {
                            Console.Clear();
                            do
                            {

                                Console.WriteLine("What type of transaction would you like to do?\n" +
                                    "D) Deposit\n" +
                                    "W) Withdrawal\n" +
                                    "B) Balance\n" +
                                    "X) Exit");
                                ConsoleKey userSelection = Console.ReadKey(true).Key;
                                Console.Clear();

                                switch (userSelection)
                                {

                                    case ConsoleKey.D:
                                        Console.WriteLine($"Your Account Balance: {accountBalance}\n" +
                                            $"How much would you like to deposit? $");
                                        string userDeposit = Console.ReadLine();
                                        decimal userDeposit2 = decimal.Parse(userDeposit);
                                        Console.Clear();
                                        Console.WriteLine($"Your new account balance is: $" + (accountBalance = accountBalance + userDeposit2));
                                        Console.WriteLine("\nWould you like to do another transaction? Y|N");
                                        string doAnother1 = Console.ReadLine().ToUpper();
                                        if (doAnother1 == "Y")
                                        {
                                            doAnother = false;
                                        }
                                        if (doAnother1 == "N")
                                        {
                                            doAnother = true;
                                        }
                                        Console.Clear();

                                        break;
                                    case ConsoleKey.W:
                                        Console.WriteLine($"Your Account Balance: {accountBalance}\n" +
                                            $"How much would you like to withdraw? $");
                                        string userWithdraw = Console.ReadLine();
                                        decimal userWithdraw2 = decimal.Parse(userWithdraw);
                                        Console.Clear();
                                        Console.WriteLine($"Your new account balance is: $" + (accountBalance = accountBalance - userWithdraw2));
                                        Console.WriteLine("\nWould you like to do another transaction? Y|N");
                                        string doAnother2 = Console.ReadLine().ToUpper();
                                        if (doAnother2 == "Y")
                                        {
                                            doAnother = false;
                                        }
                                        if (doAnother2 == "N")
                                        {
                                            doAnother = true;
                                        }
                                        Console.Clear();
                                        break;
                                    case ConsoleKey.X:
                                        Console.WriteLine("Thank you for choosing First Operational Bank, we hope to see you again soon!");
                                        break;
                                    case ConsoleKey.B:
                                        Console.WriteLine($"Your Account Balance is: $" + accountBalance);
                                        Console.WriteLine("\nWould you like to do another transaction? Y|N");
                                        string doAnother3 = Console.ReadLine().ToUpper();
                                        if (doAnother3 == "Y")
                                        {
                                            doAnother = false;
                                        }
                                        if (doAnother3 == "N")
                                        {
                                            doAnother = true;
                                        }
                                        Console.Clear();
                                        break;


                                }//end switch
                            } while (doAnother != true);
                        }//end if
                        else
                        {
                            Console.WriteLine("PIN incorrect, please try again: ");
                            passwordAttempts++;
                            
                        }
                    }//end if

                    else
                    {
                        Console.WriteLine("Username incorrect, please try again: ");
                        loginAttempts++;
                        
                    }
                    
                    if (loginAttempts == 3) {
                        System.Environment.Exit(0);
                    }
                    if (passwordAttempts == 3)
                    {
                        System.Environment.Exit(0);
                    }    
                    
                }// end for
            } while (doAnother != true);






        }//end main
    }//end class
}//end namespace
