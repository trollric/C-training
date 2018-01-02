using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passing ref-types by value
            Console.WriteLine("****** Passing Person Object by Value ******");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();
            SendApersonByValue(fred);
            Console.WriteLine("\nAfter by value call:");
            fred.Display();
            Console.ReadLine();
        }

        static void SendApersonByValue(Person p)
        {
            // Change the age of p
            p.personAge = 99;
            // Will the caller see this reassignment?
            p = new Person("Nikki", 80);
        }
    }
}
