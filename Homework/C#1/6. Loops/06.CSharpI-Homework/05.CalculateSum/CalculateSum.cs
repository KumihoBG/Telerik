using System;


/*
 * Write a program that, for a given two integer numbers  n  and  x , calculates the sum  S = 1 + 1!/x + 2!/x2 + … + n!/xn .
 * Use only one loop. Print the result with  5  digits after the decimal point.
*/

class CalculateSum
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine());

        double sum = 1;

        for (int factorial = 1,i = 1; i <= N;i++ )
        {
            factorial *= i;
            sum += (double) factorial / Math.Pow(X,i);
        }

        Console.WriteLine("Sum: {0:F5}",sum);
    }
}
