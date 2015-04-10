using System;
using System.Numerics;

/*
 * In combinatorics, the number of ways to choose  k  different members out of a group of  n  different elements (also known as the number of combinations)
 * is calculated by the following formula:  For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
 * Your task is to write a program that calculates  n! / (k! * (n-k)!)  for given  n  and  k  (1 < k < n < 100). Try to use only two loops.
*/

class Calculate
{
    static void Main()
    {
        int N = 0,K = 0;

        do{
            Console.WriteLine("Enter N between 1 and 99: ");

        }while(int.TryParse(Console.ReadLine(), out N)==false || N < 1 || N >= 100);

        do{
            Console.WriteLine("Enter K between 1 and N: ");

        }while(int.TryParse(Console.ReadLine(), out K)==false || K < 1 || K > N);

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        for(int i = 1;i <= N;i++)
        {
            if(i <= K)
            {
                factorialK *= i;
            }

            factorialN *= i;
        }

        BigInteger factorialDiffNK = 1;
        int diffNK = N - K;

        for(int i = 1;i <= diffNK;i++)
        {
            factorialDiffNK *= i;
        }

        BigInteger result = factorialN / (factorialK * factorialDiffNK);

        Console.WriteLine("Result: " + result);
    }
}
