using System;

/*
 * Write a program that calculates the greatest common divisor (GCD) of given two integers  a  and  b .
 * Use the Euclidean algorithm (find it in Internet).
*/

class CalculateGCD
{
    static void Main()
    {
        int numberA = int.Parse(Console.ReadLine());
        int numberB = int.Parse(Console.ReadLine());

        int divident = Math.Max(numberA, numberB);
        int divisor = Math.Min(numberA, numberB);

        int remainder = 0;

        while(true) {

            remainder = divident % divisor;
            divident = divisor;

            if (remainder > 0)
            {
                divisor = remainder;
            }
            else
            {
                break;
            }

        }

        Console.WriteLine(divisor);
    }
}
