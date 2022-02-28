using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The program that takes 10 numbers from the user and displays the sum of these numbers on the screen.

            int num, total = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the {0}. number: ", i + 1);
                num = int.Parse(Console.ReadLine());
                total += num;
            }
            Console.WriteLine("Total = " + total);
            
            Console.ReadKey();
        }
    }
}
