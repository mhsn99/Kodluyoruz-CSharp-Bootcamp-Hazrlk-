using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // simple Body Mass Index calculator

            Console.Write("Enter your height in meters(m) (like 1,75): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your weight in kilograms (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / Math.Pow(height,2);

            if (bmi < 18.5)
                Console.WriteLine("BMI = {0} - Underweight",bmi);
            else if (bmi >= 18.5 && bmi <= 24.99)
                Console.WriteLine("BMI = {0} - Normal",bmi);
            else if(bmi >=25 && bmi <= 29.99)
                Console.WriteLine("BMI = {0} - Overweight",bmi);
            else if(bmi>=30 && bmi<=34.99)
                Console.WriteLine("BMI = {0} - Obese",bmi);
            else
                Console.WriteLine("BMI = {0} - Extremely Obese",bmi);

            Console.ReadKey();
        }
    }
}
