using System;
using System.Numerics;

/*
 * Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
 * Use only one loop.
*/

class Calculate
{
    static void Main()
    {
        int N = 0,K = 0;

        do
        {
            Console.WriteLine("Enter N between 1 and 99: ");

        } while (int.TryParse(Console.ReadLine(), out N)==false || N<1 || N>=100);

        do
        {
            Console.WriteLine("Enter K between 1 and N-1: ");

        }while (int.TryParse(Console.ReadLine(), out K)==false || K<1 || K>N);

        BigInteger factorialN = 1, factorialK = 1;

        for (int i = 1;i <= N;i++ )
        {
            if(i <= K)
            {
                factorialK *= i;
            }

            factorialN *= i;
        }

        Console.WriteLine("Result: " + (factorialN / factorialK));
    }
}

