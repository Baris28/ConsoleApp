using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array declaration
            string[] menuItems;
            int[] menuItemPrices;

            // Array Init
            menuItems = new string[4]
            {
                "Kapsalon: 6,50 euro", "XXL Kapsalon: 10,00 euro", "Turkse Pizza: 3,00 euro",
                "Broodje döner 3,50 euro"
            };

            // Write everything to console
            Console.WriteLine("Onze menu: ");
            Array.ForEach(menuItems, Console.WriteLine);
            Console.ReadLine();
        }
    }
}
