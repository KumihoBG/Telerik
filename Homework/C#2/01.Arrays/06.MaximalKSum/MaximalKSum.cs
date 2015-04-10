using System;

namespace MaximalKSum
    {
    internal class MaximalKSum
        {
        private static void Main()
            {
            // Write a program that reads two integer numbers N and K and an array of N elements from the console;
            // Find in the array those K elements that have maximal sum;
            // input of N, K and the array numbers:
            Console.Write("Enter the number N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number K: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string text = Console.ReadLine();
            char[] space = { ',', ' ' };
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[newStringInput.Length];
            for (int i = 0; i < newStringInput.Length; i++)
                {
                arr[i] = int.Parse(newStringInput[i]);
                }

            //finding the max subarray
            int sum = 0;
            int maxSum = 0; //stores the max(temp) sum found of the K elements
            int indexK = 0;
            int count = 1;

            for (int i = 0; i < n - k; i++) //checking the elements in the array "n-k" times
                {
                int j = i;
                for (; j < i + k; j++) // finds all K elemements that have maximum sum - "i + K" times
                    {
                    sum += arr[j]; // sums the K elements on every cycle of the loop
                    }
                    if (k > n)
                    {
                        Console.WriteLine("K number should be smaller than N number. Try again!");
                        break;
                    }
                if (sum > maxSum)  // if the current sum is greater than the max sum found till the moment
                    {              // the following code is executed
                    indexK = i; 
                    maxSum = sum; //if current sum is greater than the max found, then it is the max sum
                    count = j - 1; 
                    }
                sum = 0; // we reset the sum at the end of every K loop and start to sum again the next K elements
                }

            // printing the K numbers with the max sum
            for (int i = indexK; i < indexK + count; i++)
                {
                if (i != indexK + count - 1)
                    {
                    Console.Write(arr[i] + " ");
                    }
                else
                    {
                    Console.WriteLine(arr[i]);
                    }

                }
            }
        }
    }



