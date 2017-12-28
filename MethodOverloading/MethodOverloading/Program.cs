using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            OverLoadingTheAdd();
            Console.ReadLine();
        }

        private static void OverLoadingTheAdd()
        {
            Console.WriteLine("***** Fun with Method Overloading *****\n");
            // Calls the int version of Add()
            Console.WriteLine(Add(10, 10));
            Console.WriteLine();
            // Calls the long version of Add()
            Console.WriteLine(Add(90000000000000000, 12000000000000000));
            Console.WriteLine();
            // Calls the double version of Add()
            Console.WriteLine(Add(19.5, 65.3));
            Console.WriteLine();
            
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
