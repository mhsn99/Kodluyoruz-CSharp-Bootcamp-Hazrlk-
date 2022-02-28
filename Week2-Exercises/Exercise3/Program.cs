using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sorting the Array Alphabetically (Alphabetically sorting the string of words that the user will enter)
            Console.Write("How many words do you want do enter?: ");
            int lenArr = Convert.ToInt32(Console.ReadLine());
            string[] wordArr = new string[lenArr];

            for (int i = 0; i < lenArr; i++)
            {
                Console.Write("Enter the {0}. words: ",i+1);
                wordArr[i] = Console.ReadLine();
            }
            Array.Sort(wordArr);
            Console.WriteLine("Sorting the Array Alphabetically");
            foreach (string word in wordArr)
                Console.Write(word + " ");

            Console.ReadKey();
        }
    }
}
