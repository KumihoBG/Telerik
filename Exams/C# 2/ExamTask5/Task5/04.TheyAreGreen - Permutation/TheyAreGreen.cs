﻿using System;

public class TheyAreGreen
    {
    /// <summary>
    /// The entry point of the program
    /// </summary>
    internal static void Main()
        {
        // Read input
        var numberOfLetters = int.Parse(Console.ReadLine());
        var letters = new char[numberOfLetters];
        for (int i = 0; i < numberOfLetters; i++)
            {
            letters[i] = char.Parse(Console.ReadLine());
            }

        // Solve problem
        var count = CountWords(letters);

        // Write output
        Console.WriteLine(count);
        }

    /// <summary>
    /// Counts the number of words that match the condition given in the problem description
    /// </summary>
    private static int CountWords(char[] letters)
        {
        Array.Sort(letters);

        var count = 0;
        do
            {
            if (IsValidWord(letters))
                {
                count++;
                }
            }
        while (NextPermutation(letters));

        return count;
        }

    /// <summary>
    /// Checks whether a given array of chars is a valid word according to the problem description
    /// </summary>
    private static bool IsValidWord(char[] letters)
        {
        for (int i = 1; i < letters.Length; i++)
            {
            if (letters[i] == letters[i - 1])
                {
                return false;
                }
            }

        return true;
        }

    /// <summary>
    /// Transform array of chars to next permutation.
    /// Rearranges the elements into the next lexicographically greater permutation.
    /// </summary>
    /// <param name="array">The array of elements to be sorted</param>
    /// <returns>
    /// true if the function could rearrange the object as a lexicographically greater permutation.
    /// Otherwise, the function returns false to indicate that the arrangement is not greater than the previous, but the lowest possible (sorted in ascending order).
    /// </returns>
    private static bool NextPermutation(char[] array)
        {
        for (int index = array.Length - 2; index >= 0; index--)
            {
            if (array[index] < array[index + 1])
                {
                int swapWithIndex = array.Length - 1;
                while (array[index] >= array[swapWithIndex])
                    {
                    swapWithIndex--;
                    }

                // Swap i-th and j-th elements
                var tmp = array[index];
                array[index] = array[swapWithIndex];
                array[swapWithIndex] = tmp;

                Array.Reverse(array, index + 1, array.Length - index - 1);
                return true;
                }
            }

        // No more permutations
        return false;
        }
    }
