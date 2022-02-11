using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_If_ElseIf_Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            // if elseif else
            if (time >= 6 && time < 11)
                Console.WriteLine("Good Morning!");
            else if (time <= 18)
                Console.WriteLine("Have a nice day!");
            else
                Console.WriteLine("Goodnight!");

            // ternary
            string sonuc = time >= 6 && time <= 10 ? "Good Morning!" : time <= 18 ? "Have a nice day!" : "Goodnight!";
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
