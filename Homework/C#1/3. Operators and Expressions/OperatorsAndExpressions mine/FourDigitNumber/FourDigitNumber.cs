namespace FourDigitNumber
{
    using System;
    class FourDigitNumber
    {
        static void Main()
        {
            // Write a program that takes as input a four-digit number in format abcd and perform operations, as follows:
            Console.WriteLine("Please, enter a four-digit number:");
            int myNumber = int.Parse(Console.ReadLine());
            int a = (myNumber / 1000) % 10;
            int b = (myNumber / 100) % 10;
            int c = (myNumber / 10) % 10;
            int d = myNumber % 10;
            int abcd = a + b + c + d;
            int reversed = 1000 * d + 100 * c + 10 * b + a;
            int firstDigitChanged = 1000 * d + 100 * a + 10 * b + c;
            int secondDigitChanged = 1000 * a + 100 * c + 10 * b + d;
            Console.WriteLine();

            // Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4);
            Console.WriteLine("The sum of the four numbers is: {0}", abcd);
            Console.WriteLine();

            // Prints on the console the number in reversed order: dcba (in our example 1102);
            Console.WriteLine("This is their reverse order: {0}", reversed);
            Console.WriteLine();

            // Puts the last digit in the first position: dabc (in our example 1201);
            Console.WriteLine("Now the last digit becomes the first: {0}", firstDigitChanged);
            Console.WriteLine();

            // Exchanges the second and the third digits: acbd (in our example 2101);
            Console.WriteLine("Now the second and the third digits are exchanged: {0}", secondDigitChanged);
            Console.WriteLine();
            Console.WriteLine("Thank you, that was all!");
        }
    }
}
