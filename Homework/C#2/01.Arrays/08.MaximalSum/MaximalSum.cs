using System;

// Write a program that finds the sequence of maximal sum in given array:
// input {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
// Can you do it with only one loop (with single scan through the elements of the array)?

namespace MaximalSum
    {
    internal class MaximalSum
        {
        private static void Main()
            {
            // input from the console:
            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string text = Console.ReadLine();
            char[] space = { ',', ' ' };
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] someNumbers = new int[newStringInput.Length];
            int i;
            for (i = 0; i < newStringInput.Length; i++)
                {
                someNumbers[i] = int.Parse(newStringInput[i]);
                }

            // using loop to check all array elements;
            // using 2 variables to store the current sum and the "best" sum;
            // in order to print correctly, we are creating 2 variables - starIndex and bestEnd;
            
            int bestSum = int.MinValue;
            int sum = 0;
            int startIndex = 0;
            int bestEnd = 0;

            for (i = 0; i < someNumbers.Length; i++)
                {
                sum += someNumbers[i]; //thats the current sum
                if (sum > bestSum)     // comparing the current and the best sum
                    {
                    bestSum = sum;
                    bestEnd = i + 1;
                    }
                else if (sum <= 0)     //if the sum is smaller or equal to zero, we reset it
                    {
                    sum = 0;
                    startIndex = i + 1;
                    }
                }

            // printing the sorted array with or without a comma, calling a method, extracted below
            PrintMyArray(startIndex, bestEnd, someNumbers, out i);
            }

        //method we created to print our array
        private static void PrintMyArray(int startIndex, int bestEnd, int[] someNumbers, out int i)
            {
            for (i = startIndex; i < bestEnd; i++)
                {
                if (i != bestEnd - 1)
                    {
                    Console.Write(someNumbers[i] + " ");
                    }
                else
                    {
                    Console.WriteLine(someNumbers[i]);
                    }
                }
            }
        }
    }

