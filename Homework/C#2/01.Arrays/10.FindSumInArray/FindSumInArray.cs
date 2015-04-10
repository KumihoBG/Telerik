using System;

namespace FindSumInArray
    {
    internal class FindSumInArray
        {
        private static void Main()
            {
            // Write a program that finds in given array of integers a sequence of given sum S (if present);
            // Ex. array = {4, 3, 1, 4, 2, 5, 8}, sum = 11, result = 4, 2, 5
            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string text = Console.ReadLine();
            char[] space = { ',', ' ' };
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] numbersArray = new int[newStringInput.Length];
            int i;
            for (i = 0; i < newStringInput.Length; i++)
                {
                numbersArray[i] = int.Parse(newStringInput[i]);
                }
            Console.Write("Enter the number S /the given sum/: ");
            int sum = int.Parse(Console.ReadLine());

            // calling the method for our calculations
            FindSequenceOfGivenSum(numbersArray, sum);
            }

        static void PrintArray(int startIndex, int endIndex, int[] array) //method for printing our sequence
            {
            Console.WriteLine("Sequence of given sum is present:");
            Console.Write("{ ");
            for (int i = startIndex; i <= endIndex; i++)
                {
                Console.Write("{0} ", array[i]);
                }
            Console.Write("}");
            }

        //method for making calculations
        private static void FindSequenceOfGivenSum(int[] numbersArray, int sum)
            {
            long currentSum = 0;
            for (int i = 0; i < numbersArray.Length; i++) //checking all array elements
                {
                currentSum = 0;
                for (int j = i; j >= 0; j--) //checking from i to zero, decreasing j
                    {
                    currentSum += numbersArray[j]; //finding the current sum
                    if (currentSum == sum)
                        {
                        PrintArray(j, i, numbersArray); //printing if equal, calling a method
                        return;
                        }
                    }
                }
            Console.WriteLine("There is no sequence of given sum!");

            }
        }
    }

