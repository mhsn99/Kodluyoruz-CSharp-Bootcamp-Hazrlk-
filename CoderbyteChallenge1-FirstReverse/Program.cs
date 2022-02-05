using System;


namespace CoderbyteChallenge1_FirstReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstReverse(Console.ReadLine()));
            
            Console.ReadKey();
            
        }
        public static string FirstReverse(string str)
        {

            // code goes here
            string temp = string.Empty;
            for (int i = str.Length-1; i >=0 ; i--)
            {
                temp += str[i];
            }
            str = temp;
            return str;

        }
    }
}
