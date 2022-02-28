using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List numbers between 1 and n that are divisible by 3 and 7
            Console.Write("Enter the N value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("List numbers between 1 and {0} that are divisible by 3 and 7: ", n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                    Console.Write("{0} ", i);
                
            }
            Console.ReadKey();
        }
    }
}
