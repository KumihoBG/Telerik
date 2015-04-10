// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;

class PrimeNumbers
    {
    static void Main()
        {
        /* applying the Sieve of Eratosthenes means, that we will flag all not-prime numbers as not-prime
         and whatever has remained outside the set of numbers flagged as not-prime, will be prime */

        HashSet<int> Primes = new HashSet<int>();

        // we will use this bool array, to store the information about postions between 1 and 10 000 000 
        // at which the numbers are prime or not-prime
        bool[] bigArr = new bool[10000000];

        // we first set all positions in the bool array to true, all numbers will be considered prime unless proven otherwise
        for (int i = 0; i < bigArr.Length; i++)
            {
            bigArr[i] = true;
            }

        // this for loop supplies the base numbers for the calculation of the not-prime numbers
        for (int i = 2; i < Math.Sqrt(bigArr.Length); i++)
            {
            if (bigArr[i])
                {
                // not prime numbers are calculated like that: j = i * i 
                // and et each step j increases with one more i; example: j = 2 * 2; and increases with 2 at each step
                for (int j = i * i; j < bigArr.Length; j = j + i)
                    {
                    bigArr[j] = false; // we mark the position as false
                    }
                }
            }
        // if the position of a number into the bool array is still marked as true
        // we add the number to the Primes list, as this number is obviously proven to be prime
        for (int i = 0; i < bigArr.Length; i++)
            {
            if (bigArr[i])
                {
                Primes.Add(i);
                }
            }
        // preparing for print and printing
        string primes = string.Join(", ", Primes);
        Console.WriteLine(primes);
        }
    }