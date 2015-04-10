namespace AgeAfterTenYears
{
    using System;
    using System.Globalization;
    using System.Threading;

    class AgeAfterTenYears
    {
        static void Main()
        {
            // This programs shows your current age after ten years using the DateTime.AddYears Method and
            // if-else statements;
            CultureInfo bg = new CultureInfo("bg-BG");
            Thread.CurrentThread.CurrentCulture = bg;
            Console.WriteLine("Enter your birthday date (DD/MM/YYYY):");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = 0;
                if (today.Month < birthday.Month)
                {
                    age = today.Year - birthday.Year - 1;
                }
                else if (today.Month > birthday.Month)
                {
                    age = today.Year - birthday.Year;
                }
                else
                {
                    if (today.Day < birthday.Day)
                    {
                        age = today.Year - birthday.Year - 1;
                    }
                    else
                    {
                        age = today.Year - birthday.Year;
                    }
                }
            Console.WriteLine("Your current age is {0} and in 10 years your age will be {1}", age, age + 10);
        }
    }
}