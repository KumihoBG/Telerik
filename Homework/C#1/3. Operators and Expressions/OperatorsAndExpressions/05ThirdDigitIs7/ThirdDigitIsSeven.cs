﻿//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;


class ThirdDigitIsSeven
{
    static void Main()
    {
        bool IsItSeven = false;
        Console.Write("Enter number:");
        int number;
        bool isInt = int.TryParse(Console.ReadLine(), out number);
        if (isInt)
        {
            if (number % 1000 > 699 && number % 1000 < 800)
            {
                IsItSeven = true;
            }
            Console.WriteLine("{0}", IsItSeven);
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}