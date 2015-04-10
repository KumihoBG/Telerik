using System;
using System.Globalization;

// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian;

namespace _17.DateInBulgarian
    {
    class DateInBulgarian
        {
        static void Main()
            {
            // the input
            Console.WriteLine("Enter a date in format \"dd.MM.yyyy HH:mm:ss\": ");
            string startingDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(startingDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            // changing the culture
            CultureInfo bg = new CultureInfo("bg-BG");

            // adding 6.5 hours
            DateTime newTime = date.AddHours(6.5);
            // getting the exact day
            string day = bg.DateTimeFormat.GetDayName(date.DayOfWeek);

            // printing the result
            Console.WriteLine("The date and time after 6 hours and 30 minutes will be: {0:dd.MM.yyyy HH:mm:ss} {1}", newTime, day);
            }
        }
    }
