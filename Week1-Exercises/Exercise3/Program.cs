using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that calculates the area and perimeter of a rectangle and displays it on the screen.
            Console.Write("Short edge: ");
            int sEdge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Long edge: ");
            int lEdge = Convert.ToInt32(Console.ReadLine());
            if (sEdge > lEdge)
                Console.WriteLine("The length of the long edge cannot be shorter than the length of the short edge.");
            else
            {
                Console.WriteLine("Rectangle Area: {0}", (sEdge * lEdge));
                Console.WriteLine("Rectangle Perimeter: {0}", ((sEdge + lEdge) * 2));
            }
            Console.ReadKey();

        }
    }
}
