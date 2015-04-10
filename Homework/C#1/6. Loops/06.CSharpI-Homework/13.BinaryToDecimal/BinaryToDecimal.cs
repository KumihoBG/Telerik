using System;

/*
 * Using loops write a program that converts a binary integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.
 * Do not use the built-in .NET functionality.
*/

class BinaryToDecimal
{
    static void Main()
    {
        string inputStr = Console.ReadLine();

        long result = 0;
        for(int i = 0, j = inputStr.Length - 1;i < inputStr.Length;i++,j--)
        {
            if (inputStr[i] == '1')
            {
                result = result | (uint)(1 <<j);
            }
        }

        Console.WriteLine(result);
    }

}

