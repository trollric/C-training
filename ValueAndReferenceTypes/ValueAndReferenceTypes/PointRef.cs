using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class PointRef
    {
        // Fields of the structure.
        public int X;
        public int Y;
        // Constructor
        public PointRef(int Xpos, int Ypos)
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
}
