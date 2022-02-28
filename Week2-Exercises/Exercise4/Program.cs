using System;
using System.Linq;


namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to Find Vowels in Entered Text
            char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int totalVowel = 0;

            Console.WriteLine("Enter the your text: ");
            string text = Console.ReadLine();

            text = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                if(vowels.Contains(text[i]))
                    totalVowel++;
            }

            Console.WriteLine("Total vowels = " + totalVowel);
            Console.ReadKey();

        }
    }
}
