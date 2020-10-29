using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args) {

            // Capture date from console calculate how many days ago it was
            Console.Write("Give me a date: ");
            string previousDateString = Console.ReadLine();

            Console.WriteLine("What date format you want to do:");
            string formatDate = Console.ReadLine();

            if (formatDate.Length < 1)
            {
                formatDate = "MM/dd/yyyy";
            }

            //pending find how to fix ParseExact 
            DateTime previousDate = DateTime.Parse(previousDateString);

            TimeSpan fromPreviousDate = DateTime.Now.Subtract(previousDate);

            if (fromPreviousDate.Ticks > 0)

                Console.WriteLine($"It has been {fromPreviousDate.Days} days since { previousDate}");

            else

                Console.WriteLine($"It has been {-fromPreviousDate.Days} days { Math.Round(fromPreviousDate.TotalDays, 0, MidpointRounding.AwayFromZero)} in the future");

            //Console.Write("Give me a time: ");
            //string previousTimeString = Console.ReadLine();

            //Console.Write("What time format do you want to use");
            //string timeFormat = Console.ReadLine();

            //if (timeFormat.Length < 1)
            //{
            //    timeFormat = "h:mm tt";
            //} 
            //DateTime previousTime = DateTime.ParseExact(previousTimeString, timeFormat, null);

            //TimeSpan fromPreviousTime = DateTime.Now.Subtract(previousTime);

            //if( fromPreviousTime.Ticks < 0 )
            //{
            //    fromPreviousTime = fromPreviousTime.Add(TimeSpan.FromHours(24));
            //}

            //Console.WriteLine($"{previousTimeString } was { fromPreviousTime.Hours} hours and { fromPreviousTime.Minutes} minutes ago");

            //Console.ReadLine();
        }
    }
}
