namespace IsThirdDigitSeven
{
    using System;
    class IsThirdDigitSeven
    {
        static void Main()
        {
            // Write an expression that checks for given integer if its third digit from right-to-left is 7;

            Console.WriteLine("Please, enter a number to check if its 3rd digit is 7:");
            int someNumber = int.Parse(Console.ReadLine());
            int numberDevidedByHundred = someNumber/100;
            int thirdDigit = Math.Abs(numberDevidedByHundred % 10);
            bool isThirdDigit7 = thirdDigit == 7;
            Console.WriteLine("The result is: " + isThirdDigit7);
        }
    }
}
