using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_ArrayDefinition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining array
            string[] colors = new string[5];
            string[] animals = {"Cat","Dog","Bird","Monkey"};
            int[] arr;
            arr = new int[5];

            // Assigning and accessing values ​​to arrays
            colors[0] = "Blue";
            arr[3] = 10;

            Console.WriteLine(colors[0]);
            Console.WriteLine(animals[1]);
            Console.WriteLine(arr[3]);

            // Arrays with Loop
            Console.Write("Enter the array length: ");
            int arrLength = int.Parse(Console.ReadLine());
            int[] numArr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Please enter {0}. number: ", i + 1);
                numArr[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            foreach (int i in numArr)
                total += i;

            Console.WriteLine("Average: "+(total/arrLength));
        }
    }
}
