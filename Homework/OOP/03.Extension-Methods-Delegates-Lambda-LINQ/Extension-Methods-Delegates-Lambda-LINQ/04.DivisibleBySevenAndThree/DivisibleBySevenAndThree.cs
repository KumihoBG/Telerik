// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _04.DivisibleBySevenAndThree
    {
    using System;
    using System.Linq;

    /// <summary>
    /// A class for division of numbers with lambda expressions and LINQ
    /// </summary>
    class DivisibleBySevenAndThree
        {
        /// <summary>
        /// The main method
        /// </summary>
        static void Main()
            {
            // using lambda expression
            int[] someNumbers = new[] { 21, 5, 7, 9, 101, 2, 3, 77, 1, 11, 88, 4, 42, 84, 32, 91, 43 };
            Console.WriteLine("Problem 6 --> The list of integers that are divisible by 7 and 3, using lambda expression");
            Console.WriteLine(new string('*', 90));
            var result = someNumbers.Where(x => x % 21 == 0).ToArray();

            foreach (var number in result)
                {
                Console.WriteLine(number + " ");
                }
            Console.WriteLine();

            // using Linq
            Console.WriteLine("Problem 6 --> The list of integers that are divisible by 7 and 3, using LINQ");
            Console.WriteLine(new string('*', 76));
            var divisableNumbers =
                from number in someNumbers
                where number % 21 == 0
                select number;

            foreach (var number in divisableNumbers)
                {
                Console.WriteLine(number);
                }
            Console.WriteLine();
            }
        }
    }
