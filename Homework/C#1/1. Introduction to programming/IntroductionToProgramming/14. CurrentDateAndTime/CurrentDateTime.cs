using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CurrentDateAndTime
{
    class CurrentDateTime
    {
        static void Main()
        {
            // This programs shows the current date and time using the globalization method;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("The current date and time is:");
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("G",CultureInfo.CreateSpecificCulture("en-us")));
            Console.WriteLine("*****************************************************************************");
            Console.Write("The current time and date in Bulgaria, Europe is: ");
            Console.WriteLine(currentDate.ToString("G", CultureInfo.CreateSpecificCulture("bg-BG")));
        }
    }
}
