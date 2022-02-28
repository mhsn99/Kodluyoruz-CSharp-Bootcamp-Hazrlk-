using System;


namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that shows whether 10 numbers randomly picked up by the computer are even or odd.

            Random random = new Random();
            int num;
            for (int i = 0; i < 10; i++)
            {
                num = random.Next(1,100);

                if(num % 2 == 0)
                    Console.WriteLine("{1}. number '{0}' is the even", num, i + 1);
                else
                    Console.WriteLine("{1}. number '{0}' is the odd", num, i + 1);
            }
            Console.ReadKey();
        }
    }
}
