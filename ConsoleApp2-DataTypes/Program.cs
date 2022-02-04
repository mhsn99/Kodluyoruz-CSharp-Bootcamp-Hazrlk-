using System;

namespace ConsoleApp2_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b = 5; // 1 byte
            sbyte s = 5; // 1 byte

            short s1 = 5; // 2 byte
            ushort s2 = 5; // 2 byte

            Int16 i = 5; // 2 byte
            int i2 = 5; // 4 byte
            Int32 i3 = 2; // 4 byte
            Int64 i4 = 2; // 8 byte
            
            uint i5 = 2; // 4 byte
            long l = 4; // 8 byte
            ulong r = 4; // 8 byte
          
            // Real numbers
            float f = 6; // 4 byte
            double g = 6; // 8 byte
            decimal de = 6; // 16 byte

            char ch = '2'; // 2 byte
            string str = "Mahsun"; // unlimited

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());
            

            object o1 = "X";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 2.5;

            // String Statements
            string str1 = string.Empty;
            str1 = "Mahsun Tay";
            string name = "Mahsun";
            string surname = "Tay";
            string fullName = name + surname;

            // Integer statements
            int integer1 = 1;
            int integer2 = 2;
            int integer3 = integer1 + integer2;

            // Boolean Statements
            bool bool1 = 10 < 2;

            // Type Conversions
            string num = "20";
            int num1 = 20;
            string numTotal = num + num1;
            Console.WriteLine(numTotal); // output is "2020"

            int num2 = num1 + Convert.ToInt32(num);
            Console.WriteLine(num2); // output is 40

            int num3 = num2 + int.Parse(num);
            Console.WriteLine(num3);

            // DateTime
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(date);

            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);

            Console.ReadKey();
        }
    }
}
