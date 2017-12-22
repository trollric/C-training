using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic for loop
            ForLoopExample();
            // Iterate array items using foreach.
            ForEachLoopExample();
            // Try foreach with LINQ
            LinqQueryOverInts();
            // Time for some while:s
            WhileLoopExample();
            // Lets do it while its hot
            DoWhileLoopExample();
            // Switch on a numerical value
            SwitchExample();
            // Swith on enum
            SwitchOnEnumExample();

            Console.ReadLine();
        }

        private static void SwitchOnEnumExample()
        {
            Console.WriteLine("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Yes, Thursday rules!");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Yes, Wednesday rules!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Yes, Tuesday rules!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Yes, Monday rules!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Yes, Saturday rules!");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Yes, Sunday rules!");
                    break;
                default:
                    Console.WriteLine("Who needs days?");
                    break;

            }
        }

        private static void SwitchExample()
        {
            Console.WriteLine("1 [C#]. 2 [VB]");
            Console.Write("Please pick your language preference: ");
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that!");
                    break;
            }
            Console.WriteLine();
        }

        private static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.WriteLine("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // Note the semi colon!
            Console.WriteLine();
        }

        private static void WhileLoopExample()
        {
            string userIsDone = "";
            // Test on a lower-class copy of the string,
            while(userIsDone != "yes")
            {
                Console.WriteLine("In the while loop");
                Console.WriteLine("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
            Console.WriteLine();
        }

        private static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ query.
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset: ");
            foreach(var i in subset)
            {
                Console.WriteLine("{0} ",i);
            }
            Console.WriteLine();
        }

        private static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            int[] myInts = { 10, 20, 30, 40 };

            foreach (string car in carTypes)
            {
                Console.WriteLine(car);
            }

            foreach(int i in myInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        private static void ForLoopExample()
        {
            // Note "i" is only visible within the scope of the for loop.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // i is not visible here.
            Console.WriteLine();
        }
    }
}
