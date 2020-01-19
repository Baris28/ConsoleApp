using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Calculator
    {
        public static double num1;
        public static double num2;
        public static double result;

        public static double AddSum()
        {

            Console.WriteLine("Type the first number here:\n");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Type the second number here:\n");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            // Put in the result variable the value inserted in num1 and num2;
            result = num1 + num2;

            // Write it to the user.
            Console.WriteLine($"Result is: {num1} + {num2} = " + (result) + "\n");

          
            return result;

        }
    }
}
