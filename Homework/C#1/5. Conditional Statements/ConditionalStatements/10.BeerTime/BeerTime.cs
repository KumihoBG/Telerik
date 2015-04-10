using System;
using System.Globalization;
class BeerTime
    {
    static void Main()
        {
        Console.Write("Enter time in format \"hh:mm tt\". Example: \"01:00 AM\": ");
        string time = Console.ReadLine();
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");

        try
            {
            DateTime beerTime = DateTime.ParseExact(time, "h:mm tt", CultureInfo.InvariantCulture);

            if (beerTime >= startTime || beerTime < endTime)
                {
                Console.WriteLine("It's beer time!");
                }
            else
                {
                Console.WriteLine("Non-beer time!");
                }
            }
        catch
            {
            Console.WriteLine("Invalid time!");
            }
        }
    }