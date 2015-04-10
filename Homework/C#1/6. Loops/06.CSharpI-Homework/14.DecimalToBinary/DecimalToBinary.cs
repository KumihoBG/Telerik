using System;

/*
 * Using loops write a program that converts an integer number to its binary representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
*/

class DecimalToBinary
{
    static void Main()
    {
        long inputDigit = long.Parse(Console.ReadLine());

        string binaryDigits = string.Empty;
        long tmp = 0;

        while (inputDigit > 0)
        {
            tmp = inputDigit % 2;
            binaryDigits += tmp.ToString();

            inputDigit /= 2;
        }

        char[] result = binaryDigits.ToCharArray();
        Array.Reverse(result);

        Console.WriteLine(result);
    }
}

