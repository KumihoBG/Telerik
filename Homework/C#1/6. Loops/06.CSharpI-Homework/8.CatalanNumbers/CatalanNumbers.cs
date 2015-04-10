using System;
using System.Numerics;

/*
 * In combinatorics, the Catalan numbers are calculated by the following formula:  
 * Write a program to calculate the  nth  Catalan number by given  n  (1 < n < 100).
*/

class CatalanNumbers
{
    static void Main()
    {
        int N = 0;

        do
        {
            Console.WriteLine("Enter N between 1 and 99: ");

        } while (int.TryParse(Console.ReadLine(), out N)==false || N < 1 || N >= 100);

        BigInteger fact2N = 1;
        BigInteger factNplus = 1;
        BigInteger factN = 1;

        for (int i = 1; i <= 2*N; i++)
        {
            if (i <= N)
            {
                factN *= i;
            }

            if(i <= N+1)
            {
                factNplus *= i;
            }

            fact2N *= i;
        }

        BigInteger result = fact2N / (factNplus * factN);

        Console.WriteLine("Result: " + result);
    }
}

