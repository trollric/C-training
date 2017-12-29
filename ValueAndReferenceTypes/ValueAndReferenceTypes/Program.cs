using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
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
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
    struct Rectangle
    {
        // The Rectangle structure contains a reference type member.
        public ShapeInfo rectInfo;
        public int rectTop, rectLeft, rectBottom, rectRight;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectLeft = left;
            rectBottom = bottom;
            rectRight = right;
        }
        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, "+
                "Left = {3}, Right = {4}",rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Assigning two instrinsic value types results in
            // Two independent variables on the stack.
            ValyeTypeAssignment();
            ReferenceTypeAssignment();
            ValueTypeContainingRefType();
            Console.ReadLine();
        }

        private static void ValueTypeContainingRefType()
        {
            // Create the first Rectangle.
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
            // Now assign a new Rectangle to r1.
            Rectangle r2 = r1;
            // Change some values of r2.
            Console.WriteLine("-> Changing some values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;
            // print values of both rectangles.
            r1.Display();
            r2.Display();
            Console.WriteLine();
        }

        private static void ReferenceTypeAssignment()
        {
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;
            // Print both point refs.
            p1.Display();
            p2.Display();
            // Change p1.X and print again
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
            Console.WriteLine();
        }

        private static void ValyeTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");
            Point p1 = new Point(10, 10);
            Point p2 = p1;
            // Print both points
            p1.Display();
            p2.Display();
            // Change p1.X and print again. p2.X is not changed.
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
            Console.WriteLine();
        }
    }
}
