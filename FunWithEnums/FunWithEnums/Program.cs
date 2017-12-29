using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    enum EmpType : byte
    {
        Manager,        // = 0
        Grunt,          // = 1
        Contractor,     // = 2
        VicePresident   // = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Enums *****");
            // Make an EmpType variable
            EmpType emp = EmpType.Contractor;
            Console.WriteLine("emp is an {0} which holds the value {1}.",emp.ToString(),(byte)emp);
            AskForBonus(emp);
            // print storage for the enum
            Console.WriteLine("EmpType uses a {0} for storage",Enum.GetUnderlyingType(typeof(EmpType)));
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cyan = ConsoleColor.Cyan;
            EvaluateEnum(emp);
            EvaluateEnum(day);
            EvaluateEnum(cyan);
            Console.ReadLine();
        }

        private static void EvaluateEnum(System.Enum e)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));
            // Get all name/value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.",enumData.Length);
            // Now show the string anme and associated value, using the D format
            // flag (see Chapter3).
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",enumData.GetValue(i));
            }
            Console.ForegroundColor = prevColor;
            Console.WriteLine();
        }

        private static void AskForBonus(EmpType emp)
        {
            switch (emp)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
    }
}
