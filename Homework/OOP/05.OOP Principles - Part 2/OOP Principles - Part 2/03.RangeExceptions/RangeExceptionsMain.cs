/*Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].*/
namespace _03.RangeExceptions
    {
    using System;

    public class RangeExceptionsMain
        {
        public const int StartNumber = 1;
        public const int EndNumber = 100;
        public const string StartDate = "01.01.1980";
        public const string EndDate = "31.12.2013";

        public static void Main()
            {
            Console.Write("Enter number between {0} and {1}: ", StartNumber, EndNumber);
            var inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber < StartNumber || inputNumber > EndNumber)
                {
                throw new InvalidRangeException<int>(StartNumber, EndNumber);
                }

            Console.Write("Enter date between {0} and {1}: ", StartDate, EndDate);
            var inputDate = DateTime.Parse(Console.ReadLine());
            if (inputDate.CompareTo(DateTime.Parse(StartDate)) < 0 || inputDate.CompareTo(DateTime.Parse(EndDate)) > 0)
                {
                throw new InvalidRangeException<DateTime>(DateTime.Parse(StartDate), DateTime.Parse(EndDate));
                }
            }
        }
    }