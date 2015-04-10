using System;
using System.Globalization;
using System.Linq;
using System.Threading;

// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public 
// holidays specified preliminary as array.
class Workdays
    {
    static void Main()
        {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter a date in format (year),(month),(day) to check\n how many working days are left until that time: ");
        DateTime targetDate = DateTime.Parse(Console.ReadLine()); 
        Console.WriteLine("There are {0} working days until {1:D}.", CalculatingWorkdays.CountWorkdays(targetDate), targetDate);
        }
    }

static class CalculatingWorkdays //creating a separate class
    {
    public static int CountWorkdays(DateTime target) // and a method to calculate the working days
        {
        // finding the current DateTime
        DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        int count = 0;

        while (today != target) // while current date and the target time are different
            {
            today = today.AddDays(1); // we start to add days
            if (today.DayOfWeek != DayOfWeek.Saturday && // excluding Saturday
                today.DayOfWeek != DayOfWeek.Sunday &&   // excluding Sunday
                !today.Holidays()) // excluding the official holidays
                {
                count++;
                }
            }
        return count;
        }
    public static bool Holidays(this DateTime day) // now we must apoint the official holidays
        {
        // creating an array of all holidays during the year
        DateTime[] holidays =  
        {
            // I took 2015 as example for official holidays in the calender but they can vary each year
          new DateTime(day.Year, 01, 01),
                    new DateTime(day.Year, 03, 02),
                    new DateTime(day.Year, 03, 03),
                    new DateTime(day.Year, 04, 10),
                    new DateTime(day.Year, 04, 11),
                    new DateTime(day.Year, 04, 12),
                    new DateTime(day.Year, 04, 13),
                    new DateTime(day.Year, 05, 01),
                    new DateTime(day.Year, 05, 06),
                    new DateTime(day.Year, 09, 21),
                    new DateTime(day.Year, 09, 22),
                    new DateTime(day.Year, 12, 24),
                    new DateTime(day.Year, 12, 25),
                    new DateTime(day.Year, 12, 26)
        };
        return holidays.Contains(day.Date); // using a method .Contains() to check if the a sequence contains a given element
        }
    }

