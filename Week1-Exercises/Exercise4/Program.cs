using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to find out if the entered number is odd or even
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("{0} is even number", num);
            else
                Console.WriteLine("{0} is odd number", num);

            Console.ReadKey();
        }
    }
}
