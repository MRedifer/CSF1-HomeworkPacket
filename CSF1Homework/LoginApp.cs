using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class LoginApp
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isAdminPassword = false;
            int loginAttempts = 0;
            int passwordAttempts = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter your username: ");
                string userName = Console.ReadLine().ToUpper();

                if (userName == "MICHAEL")
                {
                    isAdmin = true;
                }


                if (isAdmin)
                {
                    Console.WriteLine("Please enter your Password: ");
                    string userPassword = Console.ReadLine().ToUpper();
                    if (userPassword == "PASSWORD")
                    {
                        isAdminPassword = true;
                    }
                    if (isAdminPassword)
                    {
                        Console.WriteLine("You have all accesses");
                    }
                    else
                    {
                        Console.WriteLine("Password incorrect, please try again: ");
                        passwordAttempts++;
                    }

                }
                else
                {
                    Console.WriteLine("Username incorrect, please try again: ");
                    loginAttempts++;
                }
            }







        }//end main
    }//end class
}//end namespace
