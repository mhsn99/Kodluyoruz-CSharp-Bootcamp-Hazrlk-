using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderbyteChallenge2_CountingMinutes
{
    internal class Program
    {
        public static string CountingMinutes(string str)
        {

            // // Data editing for converting data to time over sample data
            if (str.Contains("pm"))
                str = str.Replace("pm", "PM");
            if (str.Contains("am"))
                str = str.Replace("am", "AM");

            string[] minuteArray = str.Split('-'); // separate the times

            for (int i = 0; i < minuteArray.Length; i++) // continue editting
            {
                if (minuteArray[i].Contains("PM"))
                    minuteArray[i] = minuteArray[i].Insert(minuteArray[i].IndexOf("P"), " ");
                if (minuteArray[i].Contains("AM"))
                    minuteArray[i] = minuteArray[i].Insert(minuteArray[i].IndexOf("A"), " ");
            }

            DateTime[] dateTimes = new DateTime[2]; // main array to store data

            for (int i = 0; i < dateTimes.Length; i++)
                dateTimes[i] = DateTime.ParseExact(minuteArray[i], "h:mm tt", CultureInfo.InvariantCulture);

            TimeSpan duration = dateTimes[1] - dateTimes[0]; // calculate difference

            if (duration.TotalMinutes >= 0) // show the difference
                return duration.TotalMinutes.ToString();
            else
                return (1440 + duration.TotalMinutes).ToString();

        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountingMinutes(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
