using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printing on the screen by taking the name and surname information into string variables

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", name, surname);
            Console.ReadKey();
        }
    }
}
