using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_Some_ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 23, 12, 4, 86, 72, 3, 11, 17 };
            
            // Sort
            Console.WriteLine("*** Unsorted number array ***");
            foreach (int num in numArr)
                Console.WriteLine(num);
            
            Console.WriteLine("*** Sorted number array");
            Array.Sort(numArr);
            foreach (int num in numArr)
                Console.WriteLine(num);

            // Clear
            Console.WriteLine("*** Array Clear ***");
            Array.Clear(numArr, 2, 2);
            foreach (int num in numArr)
                Console.WriteLine(num);

            // Reverse
            Console.WriteLine("*** Array Reverse ***");
            int[] numArr2 = { 23, 18, 56, 4, 12, 59, 10, 7 };
            Array.Reverse(numArr2);
            foreach (int num in numArr2)
                Console.WriteLine(num);

            // IndexOf
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(numArr2, 12));

            // Resize
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref numArr2, 5);

            foreach (int num in numArr2)
                Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
