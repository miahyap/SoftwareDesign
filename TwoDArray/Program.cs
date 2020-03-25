//
// ICT2106 Software Design - 2D array example
//
// Main program.
//
// Author: Nicholas Sheppard
//
using System;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and fill a 2 x 3 array of integers
            ITwoDArray<String> array = new TwoDArrayGeneric<String>(2, 3);
            array.Set(0, 0, "Sarah"); array.Set(0, 1, null); array.Set(0, 2, "Yixin");
            array.Set(1, 0, null); array.Set(1, 1, null); array.Set(1, 2, "Faizal");

            // display the array in row major order
            ITwoDIterator<String> iter = array.CreateRowMajorIterator();
            while (!iter.IsDone())
            {
                Console.Write(iter.Current() + " ");
                iter.Next();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
