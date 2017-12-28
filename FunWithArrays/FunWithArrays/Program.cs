using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            ArrayInitialization();
            DelareImplicitArrays();
            ArrayOfObjects();
            Console.ReadLine();
        }

        private static void ArrayOfObjects()
        {
            ConsoleColor precColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("=> Array of Objects: ");
            Object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach(object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }

            Console.WriteLine();
            Console.ForegroundColor = precColor;
        }

        private static void DelareImplicitArrays()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;

            // a is really int[]
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());
            // b is really double[]
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());
            // c is really string[]
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization:");
            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[] { "one", "two", "three", "four" };
            Console.WriteLine("stringArray has {0} elements.",stringArray.Length);
            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements.",boolArray.Length);
            // Array initialization with both new keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements.", intArray.Length);
            Console.WriteLine();
        }

        private static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation:");
            // Create an array of ints containing 3 elements indexed 0, 1, 2
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            // Now print each value
            foreach(int i in myInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
