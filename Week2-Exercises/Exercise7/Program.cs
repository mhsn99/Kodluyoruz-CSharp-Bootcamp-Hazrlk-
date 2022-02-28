using System;


namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A program that prints the text entered by the user on the screen as many times as the user enters.
            Console.Write("What is your text?: ");
            string text = Console.ReadLine();
            Console.Write("How many times do you want to show the text on the screen?: ");
            int show = int.Parse(Console.ReadLine());

            for (int i = 0; i < show; i++)
            {
                Console.WriteLine("{0}. Presentation: {1}", i+1, text);
                Console.WriteLine("----------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
