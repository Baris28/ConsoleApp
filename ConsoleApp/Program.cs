using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call class
            Menu menuChoices = new Menu();

            // Call method
            Color();

            // Call MenuOption method from menuChoices class
            menuChoices.MenuOption();
        }

        private static void Color()
        {
            // Turn background color white if statement is true
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }
        }
    }
}