using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to check if the entered number is between 0-100

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0 && num <= 100)
                Console.WriteLine("Is between 0-100?: " + true);
            else
                Console.WriteLine("Is between 0-100?: " + false);

            Console.ReadKey();

        }
    }
}
