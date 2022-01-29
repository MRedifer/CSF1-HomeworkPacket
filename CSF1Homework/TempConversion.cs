using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConversion
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.Title = "Temperature Conversion";
                Console.WriteLine("==== Temperature Conversion ====\nPlease Select Which You'd Like To Convert");
                Console.WriteLine("F) Farenheit to Celsius\n" +
                    "C) Celsius to Fareheit\n" +
                    "X) Exit\n");
                ConsoleKey userChoice = Console.ReadKey(true).Key;
                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.F:
                        Console.WriteLine("Please enter a temperature(Farenheit): ");
                        int userTemp = int.Parse(Console.ReadLine());
                        Console.WriteLine($" {userTemp} in celsius is: " + ((userTemp - 32) / (9.0 / 5.0)));
                        Console.WriteLine("Do you want to do another? Y|N");
                        ConsoleKey doAnother1 = Console.ReadKey(true).Key;
                        if (doAnother1 == ConsoleKey.Y)
                        {
                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Thank You For Using My Converter!");
                        }

                        break;

                }

                switch (userChoice)
                {
                    case ConsoleKey.C:
                        Console.WriteLine("Please enter a temperature(Celsius): ");
                        int userTemp2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($" {userTemp2} in farenheit is: " + (userTemp2 * (9.0 / 5.0) + 32));
                        Console.WriteLine("Do you want to do another? Y|N");
                        ConsoleKey doAnother1 = Console.ReadKey(true).Key;
                        if (doAnother1 == ConsoleKey.Y)
                        {

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Thank You For Using My Converter!");
                        }

                        break;
                        
                }

                switch (userChoice)
                {
                    case ConsoleKey.X:
                        Console.Clear();
                        Console.WriteLine("Thank You For Using My Converter!");

                        break;
                }

            }
            while (true);


        }//end main
    }//end class
}//end namespace
