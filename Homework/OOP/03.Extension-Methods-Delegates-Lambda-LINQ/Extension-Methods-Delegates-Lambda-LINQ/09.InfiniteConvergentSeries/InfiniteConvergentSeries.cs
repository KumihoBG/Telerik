namespace _09.InfiniteConvergentSeries
    {
    using System;
    using System.Linq;

    /// <summary>
    /// A class for infinite convergent series calculations
    /// </summary>
    class InfiniteConvergentSeries
        {
        /// <summary>
        /// The main method
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Some examples: ");
            Func<int, decimal> exampleOne = m => 1/(decimal) Math.Pow(2, m - 1);
            Console.WriteLine(Sum(exampleOne));

            var exampleTwo = new Func<int, decimal>(m => 1m/Enumerable.Range(1, m).Aggregate((a, b) => a*b));
            Console.WriteLine(Sum(exampleTwo));

            var exampleThree = new Func<int, decimal>(m => -1/(decimal) Math.Pow(-2, m - 1));
            Console.WriteLine(Sum(exampleThree));                           
            }

        /// <summary>
        /// A method for calculating the function
        /// </summary>
        /// <param name="function">int and decimal</param>
        /// <returns>returns the sum</returns>
        private static decimal Sum(Func<int, decimal> function)
            {
            decimal sum = 1;

            for (int i = 2; Math.Abs(function(i)) > 0.001m; i++)
                {
                sum += function(i);
                }

            return sum;
            }
        }
    }
