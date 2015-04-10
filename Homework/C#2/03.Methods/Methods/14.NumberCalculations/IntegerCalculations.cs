using System;
using System.Linq;
// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments

namespace _14.IntegerCalculations
    {
    class IntegerCalculations
        {
        static void Main()
            {
            // the input;
            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // calling the methods from below:
            Console.WriteLine("The minimum is: {0}", Minimum(inputArray));
            Console.WriteLine("The maximum is: {0}", Maximum(inputArray));
            Console.WriteLine("The average amount is: {0}", Average(inputArray));
            Console.WriteLine("The sum of these numbers is: {0}", Sum(inputArray));
            Console.WriteLine("The product of these numbers is: {0}", Product(inputArray));
            }

        // declaring the product method
        static int Product(params int[] arr)
            {
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
                {
                product *= arr[i];
                }
            return product;
            }

        // declaring the sum method
        static int Sum(params int[] arr)
            {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                sum += arr[i];
                }
            return sum;
            }

        // declaraing the average method
        static decimal Average(params int[] arr)
            {
            decimal average = 0;
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                sum += arr[i];
                }
            average = sum / arr.Length;
            return average;
            }

        // declaring the maximum method
        static int Maximum(params int[] arr)
            {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
                {
                if (arr[i] > max)
                    {
                    max = arr[i];
                    }
                }
            return max;
            }

        // declaring the minimum method
        static int Minimum(params int[] arr)
            {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
                {
                if (arr[i] < min)
                    {
                    min = arr[i];
                    }
                }
            return min;
            }
        }
    }
