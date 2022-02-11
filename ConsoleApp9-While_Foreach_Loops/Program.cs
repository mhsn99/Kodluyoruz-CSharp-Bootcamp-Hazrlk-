using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_While_Foreach_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- While Loop ----");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int counter = 1, total = 0;
            while (counter <= num)
            {
                total += counter;
                counter++;
            }
            Console.WriteLine("Average: ",(total/num));

            Console.WriteLine("---- Foreach Loop ----");
            string[] cars = { "BMV", "Ford", "Toyota", "Nissan" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
