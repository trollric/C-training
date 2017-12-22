using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Following strings are written in Verbatim
            VerbatimTrials();
            // Trying out basic string functions.
            BasicStringFunctionality();
            // Trying out string concatenation.
            StringConcatination();
            // Trying out Escape characters.
            EscapeChars();
            // Trying out sting equality.
            StringEquality();
            // Immutability in strings.
            StringsAreImmutable();
            // Testing out the stringbuilder
            FunWithStringBuilder();
            // Alternative string interpolation
            StringInterpolation();
            Console.ReadLine();
        }

        private static void StringInterpolation()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Some local variables we will plug into our larger string
            int age = 4;
            string name = "Soren";
            // Using curly bracket syntax.
            string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
            string greeting2 = $"Hello {name} you are {age} years old.";
            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
            string greeting3 = string.Format("Hello {0} you are {1} years old.", name.ToUpper(), age);
            string greeting4 = $"Hello {name.ToUpper()} you are {age} years old.";
            Console.WriteLine(greeting3);
            Console.WriteLine(greeting4);


            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void FunWithStringBuilder()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("=> Using StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deuz Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.",sb.Length);

            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void StringsAreImmutable()
        {
            ConsoleColor precColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=> String Imutablility");

            // Set initial string value
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);
            string upperString = s1.ToUpper();
            Console.WriteLine("upperstring = {0} However s1 = {1}",upperString,s1);

            Console.WriteLine();
            Console.ForegroundColor = precColor;
        }

        private static void StringEquality()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("=> String Equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}",s1);
            Console.WriteLine("s2 = {0}",s2);
            Console.WriteLine();
            // Test these strings for equality.
            Console.WriteLine("s1 == s2: {0}",s1==s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}",s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}",s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}",s1.Equals(s2));
            Console.WriteLine("Yo!.Equals(s2): {0}","Yo!".Equals(s2));
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void VerbatimTrials()
        {
            Console.WriteLine(@"C:MyApp\bin\Debug");
            Console.WriteLine();
            string mylongString = @"This is a 
very
        very
                   very
                            Long string";
            Console.WriteLine(mylongString);
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
            Console.WriteLine();
        }

        private static void EscapeChars()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=> Escape characters\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone Loves \"Hello World\"\a");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // Adds a total of 4 blank lines then beep again!)
            Console.WriteLine("All finished.\n\n\n\a ");

            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void StringConcatination()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=> String concatenation:");

            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);

            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }

        private static void BasicStringFunctionality()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=> Basic String Functionality:");

            string firstName = "Freddy";
            Console.WriteLine("Value of firstname: {0}.",firstName);
            Console.WriteLine("firstName has {0} characters.",firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}.",firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}.",firstName.ToLower());
            Console.WriteLine("does firstName contain the letter y?: {0}.",firstName.Contains('y'));
            Console.WriteLine("firstName after replace: {0}.",firstName.Replace("dy", ""));

            Console.WriteLine();
            Console.ForegroundColor = prevColor;
        }
    }
}
