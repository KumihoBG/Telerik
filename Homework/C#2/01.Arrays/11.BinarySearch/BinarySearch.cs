using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class SortArray
    {
    public abstract void Sort(Array array); //here is the Sort method
    }

namespace BinarySearch
{
    internal class BinarySearch
    {
        private static void Main()
        {
            // Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm
            // Binary search finds item in sorted array;
            // And returns index (zero based) of item
            // If item is not found returns -1

            // the input
            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string text = Console.ReadLine();
            char[] space = {',', ' '};
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] numbersArray = new int[newStringInput.Length];
            int i;
            for (i = 0; i < newStringInput.Length; i++)
            {
                numbersArray[i] = int.Parse(newStringInput[i]);
            }
            Console.Write("Enter the element of the array to search: ");
            int index = int.Parse(Console.ReadLine());

            Array.Sort(numbersArray); //callind the sorting method

            // calling and printing the method from below
            Console.WriteLine(BinarySearchAlgorythm(numbersArray, index, 0, numbersArray.Length));
        }

        public static object BinarySearchAlgorythm(int[] numbersArray, int index, int low, int high)
            {
            while (low <= high)
                {
                int middle = (low + high) / 2;
                if (index == numbersArray[middle])
                    {
                    return middle;
                    }
                else if (index < numbersArray[middle])
                    {
                    high = middle - 1;
                    }
                else
                    {
                    low = middle + 1;
                    }
                }

            // in case the element is not found in the array
            return "Not found.";
            }
    }
}
