// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace _03.IEnumerableExtensions
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Public static class holding Enumerable extension methods
    /// </summary>
    public static class EnumerableExtensions
        {
        /// <summary>
        /// The main method
        /// </summary>
        public static void Main()
            {
            int[] arrayOfInts = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] arrayOfDoubles = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] arrayOfStrings = { "16", "2", "33", "64", "5", "9", "1", "2", "10" };
            Console.WriteLine("Sum of:");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Int array:" + arrayOfInts.Sum<int>());
            Console.WriteLine("Double array:" + arrayOfDoubles.Sum<double>());
            Console.WriteLine("String array:" + arrayOfStrings.Sum<string>());
            Console.WriteLine();
            Console.WriteLine("Product of:");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Int array:" + arrayOfInts.Product<int>());
            Console.WriteLine("Double array:" + arrayOfDoubles.Product<double>());
            Console.WriteLine("String array:" + arrayOfStrings.Product<string>());
            Console.WriteLine();
            Console.WriteLine("Average of:");
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Int array:" + arrayOfInts.Average<int>());
            Console.WriteLine("Double array:" + arrayOfDoubles.Average<double>());
            Console.WriteLine("String array: {0:F2}", arrayOfStrings.Average<string>());
            Console.WriteLine();
            }

        /// <summary>
        /// Extension method for the Sum from the IEnumerable interface
        /// </summary>
        /// <typeparam name="T">random type</typeparam>
        /// <param name="input">the input data</param>
        /// <returns>the sum of the elements</returns>
        public static decimal Sum<T>(this IEnumerable<T> input)
            {
            decimal sum = 0.0M; // must use decimal in order to apply the operator directly
            try
                {
                sum = input.Aggregate(sum, (current, item) => current + Convert.ToDecimal(item));
                }
            catch (FormatException)
                {
                throw new ArgumentException("Non-numerical elements found in collection.");
                }

            return sum;
            }

        /// <summary>
        /// Extension method for the Product from the IEnumerable interface
        /// </summary>
        /// <typeparam name="T">random type</typeparam>
        /// <param name="input">the input data</param>
        /// <returns>the product of the elements</returns>
        public static decimal Product<T>(this IEnumerable<T> input)
            {
            decimal product = 1.0M; // must use decimal in order to apply the operator directly
            try
                {
                product = input.Aggregate(product, (current, item) => current * Convert.ToDecimal(item));
                }
            catch (FormatException)
                {
                throw new ArgumentException("Non-numerical elements found in collection.");
                }

            return product;
            }

        /// <summary>
        /// Extension method for the minimum element from the IEnumerable interface
        /// </summary>
        /// <typeparam name="T">random type</typeparam>
        /// <param name="input">the input data</param>
        /// <returns>the minimum element</returns>
        public static decimal Min<T>(this IEnumerable<T> input) where T : IComparable // using inheritance
            {
            decimal min = decimal.MaxValue; // must use decimal in order to apply the operator directly
            try
                {
                min = Enumerable.Max(input.Select(item => Convert.ToDecimal(item)).Concat(new[] { min }));
                }
            catch (FormatException)
                {
                throw new ArgumentException("Non-numerical elements found in collection.");
                }

            return min;
            }

        /// <summary>
        /// Extension method for the maximum element from the IEnumerable interface
        /// </summary>
        /// <typeparam name="T">random type</typeparam>
        /// <param name="input">the input data</param>
        /// <returns>the maximum element</returns>
        public static decimal Max<T>(this IEnumerable<T> input) where T : IComparable // using inheritance
            {
            decimal max = decimal.MinValue; // must use decimal in order to apply the operator directly
            try
                {
                max = Enumerable.Min(input.Select(item => Convert.ToDecimal(item)).Concat(new[] { max }));
                }
            catch (FormatException)
                {
                throw new ArgumentException("Non-numerical elements found in collection.");
                }

            return max;
            }

        /// <summary>
        /// Extension method for the Average element from the IEnumerable interface
        /// </summary>
        /// <typeparam name="T">random type</typeparam>
        /// <param name="input">the input data</param>
        /// <returns>the average elements</returns>
        public static decimal Average<T>(this IEnumerable<T> input)
            {
            int count = input.Count();
            return input.Sum<T>() / count; // dividing the sum by the total amount of elements
            }
        }
    }
