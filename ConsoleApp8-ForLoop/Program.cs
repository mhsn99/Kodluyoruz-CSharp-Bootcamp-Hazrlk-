using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int oddTotal = 0, evenTotal = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                    evenTotal += i;
                else
                    oddTotal += i;
            }
            Console.WriteLine("Odd numbers total between 1 and {0}: {1}", num, oddTotal);
            Console.WriteLine("Even numbers total between 1 and {0}: {1}", num, evenTotal);

            // break and continue
            Console.WriteLine("Break");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("---------");
            Console.WriteLine("Continue");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
