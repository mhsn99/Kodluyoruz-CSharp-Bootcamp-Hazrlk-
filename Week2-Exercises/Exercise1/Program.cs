using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Listing Prime Numbers from 1 to 1,000,000
            bool flag = false;

            Console.WriteLine("Prime Numbers (between 1-1000000): ");
            for (int i = 1; i <= 1000000; i++)
            {
                flag = false;
                if (i == 1)
                    continue;
                else if (i == 2)
                    Console.WriteLine("{0} ", i);
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = true;
                            break;
                        }

                    }
                    if(flag == false)
                        Console.WriteLine("{0} ", i);
                }

            }

            Console.ReadKey();
        }
    }
}
