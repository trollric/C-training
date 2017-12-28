using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* * * * * Fun With Methods * * * * *\n");
            int ans;
            Add(10, 9, out ans);
            Console.WriteLine("Before call, X: {0}, Y: {1}",10,9);
            Console.WriteLine("X + Y = {0}", ans);
            Console.WriteLine("After the call, X: {0}, Y: {1}",10,9);
            Console.WriteLine();

            int x = 10, y = 9;
            Console.WriteLine("Before call, X: {0}, Y: {1}", x, y);
            Console.WriteLine("X + Y = {0}", ValueAdd(x,y));
            Console.WriteLine("After the call, X: {0}, Y: {1}", x, y);
            Console.WriteLine();

            int a; string str; bool b1;
            FillTheseValues(out a, out str, out b1);
            Console.WriteLine("Int is: {0}",a);
            Console.WriteLine("String is: {0}",str);
            Console.WriteLine("Boolean is: {0}", b1);
            Console.WriteLine();

            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1}",str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}",str1,str2);
            Console.WriteLine();

            // Pass in a comma-delimited list of doubles...
            double average;
            average = CalculateAverage(4.0, 3.2, 64.22, 87.2);
            Console.WriteLine("Average of the data is: {0}",average);
            // or pass it an array of doubles
            double[] data = { 4.9, 3.2, 5.7, 103.6, 13.6 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}",average);
            // Average of 0 is 0
            Console.WriteLine("Average of 0 given parameters is: {0}",CalculateAverage());
            Console.WriteLine();

            EnterLogData("Oh no! Grid can not find data");
            EnterLogData("Oh no! I can not find the payroll data", "CFO");
            Console.WriteLine();

            DisplayFancyMessage(message: "Wow! Very fancy indeed", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);
            DisplayFancyMessage();
            DisplayFancyMessage(message: "Hello! This is neat if you only care about one parameter");

            Console.ReadLine();
        }

        static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test message")
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;
            // Set new colors and print the message
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            // Restore previous colors
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
            Console.WriteLine();
        }

        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.WriteLine("Beep(), but not at work please ^^");
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}",owner);
        }

        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.",values.Length);
            double sum = 0;
            if(values.Length == 0)
            {
                return sum;
            }
            foreach(double num in values)
            {
                sum += num;
            }
            return sum/values.Length;
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        private static int ValueAdd(int x, int y)
        {
            return x + y;
        }

        private static void FillTheseValues(out int a, out string str, out bool b1)
        {
            a = 9;
            str = "Enjoy your string.";
            b1 = true;
        }

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
    }
}
