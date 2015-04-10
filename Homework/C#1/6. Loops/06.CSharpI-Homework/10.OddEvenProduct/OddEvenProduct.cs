using System;

/*
 * You are given  n  integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from  1  to  n , so the first element is odd, the second is even, etc
*/

class OddEvenProduct
{
    static void Main()
    {
        string[] inputStr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] numbersSequence = Array.ConvertAll(inputStr, int.Parse);

        int evenProduct = 1, oddProduct = 1;

        for(int i = 1; i<=numbersSequence.Length; i++)
        {
            if ((i % 2) > 0) //odd
            {
                oddProduct *= numbersSequence[i-1];
            }
            else //even
            {
                evenProduct *= numbersSequence[i-1];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("\nYes.");
        }
        else
        {
            Console.WriteLine("\nNo.");
        }

        Console.WriteLine("odd_product = "+ oddProduct);
        Console.WriteLine("even_product = "+ evenProduct);
    }
}

