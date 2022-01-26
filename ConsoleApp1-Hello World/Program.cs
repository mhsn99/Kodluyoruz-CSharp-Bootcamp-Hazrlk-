using System;

namespace ConsoleApp1_Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter a surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Welcome {0} {1}", name, surname);
            Console.ReadKey();
        }
    }
}
