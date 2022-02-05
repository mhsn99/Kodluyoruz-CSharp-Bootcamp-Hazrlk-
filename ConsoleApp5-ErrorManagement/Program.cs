using System;

namespace ConsoleApp5_ErrorManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number is: " + num);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You did not enter a value.");
                Console.WriteLine(ex.Message);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The data type is not compatible with the value you entered..");
                Console.WriteLine(ex.Message);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The limits of the data type do not cover the value you entered.");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("The process is completed.");
                Console.ReadKey();
            }
        }
    }
}
