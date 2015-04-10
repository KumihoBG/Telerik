using System;
using System.Numerics;

// Write a program to calculate n! for each n in the range [1..100];

namespace _10.NFactorial
    {
    class NFactorial
        {
        static void Main()
            {
            // the input
            Console.WriteLine("Enter the number N: ");
            int n = int.Parse(Console.ReadLine());

            // calling the method from below
            BigInteger factorial = Factorial(n);
            Console.WriteLine("{0}! = {1}", n, factorial);
            }

        // declaring recursive method
        static BigInteger Factorial(int n)
            {
            if (n == 0) // thats the bottom of the recursion
                {
                return 1;
                }
            else
                {
                return n * Factorial(n - 1);
                }
            }
        }
    }
