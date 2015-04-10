using System;

/*
 * Using loops write a program that converts an integer number to its hexadecimal representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
*/

class DecimalToHex
{
    static void Main()
    {
        long inputDigit = long.Parse(Console.ReadLine());

        string hexDigits = string.Empty;
        long tmp = 0;

        while(inputDigit > 0)
        {
            tmp = inputDigit % 16;

            switch(tmp)
            {
                case 10: hexDigits += "A"; break;
                case 11: hexDigits += "B"; break;
                case 12: hexDigits += "C"; break;
                case 13: hexDigits += "D"; break;
                case 14: hexDigits += "E"; break;
                case 15: hexDigits += "F"; break;
                default: hexDigits += tmp.ToString(); break;
            }

            inputDigit /= 16;
        }

        char[] result = hexDigits.ToCharArray();
        Array.Reverse(result);

        Console.WriteLine(result);
    }
}

