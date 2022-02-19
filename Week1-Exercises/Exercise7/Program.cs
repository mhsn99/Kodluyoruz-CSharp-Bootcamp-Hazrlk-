using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to find the number of letters in a sentence

            int totalLetter = 0;
            Console.Write("Enter a sentence/word: ");
            string text = Console.ReadLine();

            foreach (char c in text)
            {
                if(char.IsLetter(c))
                    totalLetter++;
            }

            Console.WriteLine("Total letter the sentence/word: {0}", totalLetter);
            Console.ReadKey();
        }
    }
}
