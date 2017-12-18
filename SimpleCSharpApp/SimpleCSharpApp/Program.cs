using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            string[] arguments = Environment.GetCommandLineArgs();
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // process any incoming args
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg: {0}", args[i]);
            }

            foreach(string arg in arguments)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            // Helper method within the Program Class
            ShowEnvironmentDetails();
            // Wait for the enter key to be pressed before shutting down.
            Console.ReadLine();
            // Return an arbitrary error code
            return -1;
        }

        private static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
                Console.WriteLine("OS: {0}", Environment.OSVersion);
                Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
                Console.WriteLine(".NET version: {0}", Environment.Version);
            }
        }
    }
}
