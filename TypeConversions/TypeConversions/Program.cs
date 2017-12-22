using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Type Conversions *****");
            // Add two shorts and print the result.
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));
            // Check overflow mechanics
            ProcessBytes();
            Console.WriteLine("--------------------------------------");
            // Understanding Explicit values
            DeclareExplicitVars();
            // And Implicit
            DeclareImplicitVars();
            // Linq stuff
            LinqQueryOverInts();
            Console.ReadLine();
        }

        private static void LinqQueryOverInts()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=> Linq:y Stuff beeing done here");

            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset: ");
            foreach( var i in subset)
            {
                Console.WriteLine("{0} ",i);
            }
            Console.WriteLine();
            // Hmm... what type is subset?
            Console.WriteLine("subest is a: {0}",subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}",subset.GetType().Namespace);

            Console.ForegroundColor = prevColor;
            Console.WriteLine();
        }

        private static void DeclareImplicitVars()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=> Testing Implicit variables");

            // Implicity typed local variables
            // are declared as follows:
            // var variablename = initalValue;
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Print out the underlying types
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}",myBool.GetType().Name);
            Console.WriteLine("myString is a {0}",myString.GetType().Name);

            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void DeclareExplicitVars()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;

            // Explicity typed local variables
            // are declared as follows:
            // dataType variabelName = initValue;
            int myInt = 0;
            bool myBool = true;
            string myString = "Time, marches on...";

            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            // One way to do it
            try
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // You can also check blocks of code with checked like this
            try
            {
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Adds two numbers together
        /// </summary>
        /// <param name="x">The first number</param>
        /// <param name="y">The second number</param>
        /// <returns>The sum of x and y as an integer</returns>
        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
