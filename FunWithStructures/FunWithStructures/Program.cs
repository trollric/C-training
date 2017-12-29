using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    struct Point
    {
        // Fields of the structure.
        public int X;
        public int Y;
        // Constructor
        public Point(int Xpos, int Ypos)
        {
            X = Xpos;
            Y = Ypos;
        }
        // Add 1 to the (X, Y) position.
        public void Increment()
        {
            X++;
            Y++;
        }
        // Subtract 1 from the (X, Y) position.
        public void Decrement()
        {
            X--;
            Y--;
        }
        // Display the current position.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}",X,Y);
        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");
            // Create an initial Point
            Point myPoint;
            Point p2 = new Point();
            Point p3 = new Point(14, 75);
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();
            myPoint.Increment();
            myPoint.Display();
            p2.Display();
            p3.Display();
            Console.ReadLine();
        }
    }
}
