//Problem 17.* Subset K with sum S

/* Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
    Find in the array a subset of K elements that have sum S or indicate about its absence.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace SubsetKWithSumS
    {
    class SubsetKWithSumS
        {
        public static void Recursion(List<int> nums, int i = 0, int s = 0, int sum = 0, int k = 0, int count = 0)
            {
            if ((s == sum) && (count == k))
                {
                Console.WriteLine("yes");
                return;
                }

            for (i = 0; i < nums.Count; i++)
                {

                for (int j = i + 1; j < nums.Count; j++)
                    {
                    sum = nums[i] + nums[j];
                    Recursion(nums, i + 1, s, sum);
                    count++;
                    }
                }
            }
        static void Main(string[] args)
            {
            // input
            Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
            string inputArrayOne = Console.ReadLine();
            char[] delimiter = new char[] { ',', ' ' };
            string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[inputOne.Length];
            for (int i = 0; i < inputOne.Length; i++)
                {
                arr[i] = int.Parse(inputOne[i]);
                }

            Console.Write("Please enter a value for the required sum S: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Please enter a value for K: ");
            int k = int.Parse(Console.ReadLine());

            // declarations
            List<int> nums = arr.ToList();

            Recursion(nums);
            }
        }
    }