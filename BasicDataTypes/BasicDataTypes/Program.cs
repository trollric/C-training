using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates some local variables
            LocalVarDeclarations();
            // Creates some new local variables with the "new" keyword
            NewingDataTypes();
            // Check Object functionality
            ObjectFunctionality();
            // Check Data Types functionality
            DataTypeFunctionality();
            Console.ReadLine();
        }

        private static void DataTypeFunctionality()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=> Data type Functionality: ");
            Console.WriteLine("Max of int: {0}",int.MaxValue);
            Console.WriteLine("Min of int: {0}",int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}",double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}",double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",double.NegativeInfinity);
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void ObjectFunctionality()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=> System.Object Functionality:");
            Console.WriteLine("12.GetHashCode() = {0}",12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}",12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}",12.GetType());
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void NewingDataTypes()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0}, {1}, {2}, {3}",b, i, d ,dt);
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void LocalVarDeclarations()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=> Data Declarations:");
            // Local variables are declared and initialized as follows:
            // dataType varName = initialValue;
            int myint = 0;
            // You can also declare and assign on two lines.
            string myString;
            myString = "This is my character data";
            // Declaring three booleans on a single line
            bool b1 = true, b2 = false, b3 = b1;
            // Use System.Boolean data type to declare a bool
            System.Boolean b4 = false;
            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",myint, myString, b1, b2, b3, b4);
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }
    }
}
