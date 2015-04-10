using System;
using System.Globalization;

// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them;

namespace _16.DateDifference
    {
    class DateDifference
        {
        static void Main()
            {
            // the input
            Console.WriteLine("Enter start date in format \"dd.MM.yyyy\": ");
            string startingDate = Console.ReadLine();
            DateTime start = DateTime.ParseExact(startingDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter end date in format \"dd.MM.yyyy\": ");
            string endingDate = Console.ReadLine();
            DateTime end = DateTime.ParseExact(endingDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            // the distance between the days
            var result = start - end;

            // printing the result, using Math.Abs to format it
            Console.WriteLine("The distance between these two dates is: {0}", Math.Abs(result.Days));
            }
        }
    }
