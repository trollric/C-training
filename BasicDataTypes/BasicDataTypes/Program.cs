using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Big integer lives here
using System.Numerics;

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
            // Test out true/falsestring for bool
            BoolTrueFalseFunctionality();
            // Test Character Functionality
            CharFunctionality();
            // Testing parsing to and from strings
            ParseFromStrings();
            // Try out the DateTime and TimeSpan classes
            UseDatesAndTimes();
            // bigInt
            UseBigInteger();
            Console.ReadLine();
        }

        private static void UseBigInteger()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("=> Use BigInteger:");
            BigInteger biggy = BigInteger.Parse("99999999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}",biggy);
            Console.WriteLine("Is biggy an even value?: {0}",biggy.IsEven);
            Console.WriteLine("Is biggy a power of two?: {0}",biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}",reallyBig);
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void UseDatesAndTimes()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=> dates and Times:");
            // This constructor takes (year, month, day).
            DateTime dt = new DateTime(1990, 05, 02);
            // What date of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // Month is now December
            dt = dt.AddMonths(7);
            Console.WriteLine("Daylight savings: {0}",dt.IsDaylightSavingTime());
            // This constructor takes (hours, minutes, seconds).
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            // Subtract 15 minutes frpm the current TimeSpan and
            // print the results
            Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void ParseFromStrings()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}",b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}",d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}",c);
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void CharFunctionality()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("=> char type Functionality: ");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}",char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}",char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There',5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There',6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void BoolTrueFalseFunctionality()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=> Testing BoolStrings:");
            Console.WriteLine("bool.FalseString: {0}",bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}",bool.TrueString);
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
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
