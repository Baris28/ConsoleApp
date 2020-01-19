using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class User
    {
        public static string insertedName;

        public static string Name()
        {
            Console.WriteLine("Type your name here:\n");
            insertedName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Your name is: " + insertedName + "\n");

            return insertedName;
        }
    }
}
