using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY
// Display them in the standard date format for Canada

namespace _19.DatesFromTextInCanada
{
    internal class DatesFromTextInCanada
    {
        private static void Main()
        {
            string input =
                "I graduated school on 01.07.1999. On 05.07.2004 I graduated university. My first child was born on 16.10.2009.";
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(words[i].TrimEnd(new char[] {',', '.', '!', '?'}), "d.M.yyyy",
                        CultureInfo.InvariantCulture);
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                    Console.WriteLine("The date is represented in standard date format for Canada as: {0}", date.Date.ToLongDateString());
                }
                catch (FormatException)
                {
                }
            }
        }
    }
}

