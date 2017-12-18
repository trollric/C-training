using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Basic Console I/O *****");
            GetUserData();
            Console.ReadLine();
            // Now lets use some format tags
            FormatNumericalData();
            Console.ReadLine();
        }

        private static void FormatNumericalData()
        {
            Console.WriteLine("The nimber 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            // Notice that upper- or lowercasing for hex
            // determines if lettersare upper- or lowercase
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }

        /// <summary>
        /// Collects userdata and writes it to the console in yellow text.
        /// </summary>
        private static void GetUserData()
        {
            // Get name and age
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string age = Console.ReadLine();

            // Change echo color just for fun
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Echo to the console
            Console.WriteLine("Hello {0}! you are {1} year(s) old.",name,age);

            // Restore Foreground color
            Console.ForegroundColor = prevColor;
        }
    }
}