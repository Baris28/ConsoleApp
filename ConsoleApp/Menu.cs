using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Menu
    {
        public string MenuOption()
        {
            bool menuList = true;
            while (menuList)
            {
                // C# Menu
                Console.WriteLine("C# Menu\r");
                Console.WriteLine("------------------------\n");
                Console.WriteLine("1. Insert name here");
                Console.WriteLine("2. Insert two numbers that you want to calculate here");
                Console.WriteLine("3. Show your name and the two calculated numbers.\n");
                Console.WriteLine("Press any number key that isn't one of the above to exit the console.\n");

                string input = Console.ReadLine();
                int menuChoice = Convert.ToInt32(input);

                switch (menuChoice)
                {
                    case 1:
                        // Call the name method from User class
                        User.Name();
                        // Exit if any key other then 1 is pressed
                        exitOption();
                        break;

                    case 2:
                        // Call the AddSum method from Calculator class
                        Calculator.AddSum();
                        exitOption();
                        break;

                    case 3:
                        // Show the inserted user result and the calculated sum result
                        Console.WriteLine($"Your name is: {User.insertedName} and your calculation sum is: {Calculator.result}\n");
                        exitOption();
                        break;

                    default:
                        // Exit if any other key is pressed at start menu
                        Environment.Exit(0);
                        break;
                }
            }
            return MenuOption();
        }

        private string exitOption()
        {
            Console.WriteLine("press 1 to go back to the menu and any other key to exit console");
            // Check if inserted key is 1 if its false exit program
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                return MenuOption();

            }
            Environment.Exit(0);

            return exitOption();
        }
    }
}