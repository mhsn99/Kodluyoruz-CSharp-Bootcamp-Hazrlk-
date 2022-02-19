using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to find the sum of 2 numbers by asking the user for 2 numbers

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total = {0}",(num1+num2));
            Console.Read();
        }
    }
}
