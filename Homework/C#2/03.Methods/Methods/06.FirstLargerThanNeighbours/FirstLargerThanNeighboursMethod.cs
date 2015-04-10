using System;
// Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element;
// Use the method from the previous exercise;

namespace _05.FirstLargerThanNeighbours
    {
    class FirstLargerThanNeighboursMethod
        {
        static void Main()
            {
            // the input
            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string text = Console.ReadLine();
            char[] space = { ',', ' ' };
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] arrayOfIntegers = new int[newStringInput.Length];
            for (int i = 0; i < newStringInput.Length; i++)
                {
                arrayOfIntegers[i] = int.Parse(newStringInput[i]);
                }

            // calling our methods from below
            int result = CheckAllNeighbors(arrayOfIntegers);
            if (result != -1)
                {
                Console.WriteLine("The number, which is larger than its two neighbours, is found at position {0}", result);
                }
            else
                {
                Console.WriteLine("-1. No such number found.");
                }
            }

        // declaring our method
        static int CheckAllNeighbors(int[] array)
            {
            for (int i = 1; i < array.Length - 1; i++)
                {
                if (CheckNeighbors(array, i)) return i;
                }
            return -1;
            }
        static bool CheckNeighbors(int[] array, int position)
            {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
                {
                return true;
                }
            else return false;
            }
        }
    }
