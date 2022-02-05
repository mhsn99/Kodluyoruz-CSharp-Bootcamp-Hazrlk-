using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            Console.WriteLine("*****Implicit Conversion*****");
            byte a = 5;
            sbyte b = 10;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Mahsun";
            char f = 't';
            object g = e+ f + d;
            Console.WriteLine("g: " + g);

            // Explicit Conversion
            Console.WriteLine("*****Explicit Conversion*****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ToString Method
            Console.WriteLine("*****ToString Method*****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            //System.Convert
            Console.WriteLine("*****System.Convert*****");
            string n1 = "10", n2 = "20";
            int num1, num2, total;

            num1 = Convert.ToInt32(n1);
            num2 = Convert.ToInt32(n2);

            total = num1 + num2;
            Console.WriteLine("Total: " + total);

            // Parse
            Console.WriteLine("*****Parse*****");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string text1 = "10", text2 = "10.25";
            int numcal1;
            double double1;

            numcal1 = Int32.Parse(text1);
            double1 = Double.Parse(text2);
            Console.WriteLine("numcal1: " + numcal1);
            Console.WriteLine("double1: " + double1);
        }
    }
}
