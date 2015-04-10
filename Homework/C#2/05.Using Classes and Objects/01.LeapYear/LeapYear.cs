using System;

// Write a program that reads a year from the console and checks whether it is a leap one
// Use System.DateTime

namespace _01.LeapYear
    {
    class LeapYear
        {
        static void Main()
            {
            Console.Write("Enter year number to check if it is leap: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Is a leap year? {0}", DateTime.IsLeapYear(year));
            }
        }
    }
