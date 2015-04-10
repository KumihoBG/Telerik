using System;

/*
 * Using loops write a program that converts a hexadecimal integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.
 * Do not use the built-in .NET functionality.
*/

class HexToDecimal
{
    static void Main()
    { 
        string inputStr = Console.ReadLine();

        long result = 0;

        for(int j = 0,z = 0,i = inputStr.Length-1; z < inputStr.Length ;z++,i--)
        {
            switch(inputStr[z]) //yea i know it can be done with array ;)
            {
                case '0': j = 0; break;
                case '1': j = 1; break;
                case '2': j = 2; break;
                case '3': j = 3; break;
                case '4': j = 4; break;
                case '5': j = 5; break;
                case '6': j = 6; break;
                case '7': j = 7; break;
                case '8': j = 8; break;
                case '9': j = 9; break;
                case 'A': j = 10; break;
                case 'B': j = 11; break;
                case 'C': j = 12; break;
                case 'D': j = 13; break;
                case 'E': j = 14; break;
                case 'F': j = 15; break;
            }

            result += j * (int) Math.Pow(16,i);
        }

        Console.WriteLine(result);
    }
}
