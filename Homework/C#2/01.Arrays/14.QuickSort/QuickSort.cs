using System;
// Write a program that sorts an array of integers using the Quick sort algorithm;
//The algorithm starts by choosing a pivot value. It proceeds by partitioning the elements. Elements larger than the pivot are partitioned on the right side of the pivot and element smaller than the pivot are partitioned on the left side of the pivot. It then recursively applies the algorithm on the partitions.

namespace Quicksort
    {
    class Program
        {
        static void Main(string[] args)
            {
            // input from the console:
            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string text = Console.ReadLine();
            char[] space = { ',', ' ' };
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] unsorted = new int[newStringInput.Length];
            int i;
            for (i = 0; i < newStringInput.Length; i++)
                {
                unsorted[i] = int.Parse(newStringInput[i]);
                }

            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);

            // Print the sorted array
            for (i = 0; i < unsorted.Length; i++)
                {
                Console.Write(unsorted[i] + " ");
                }
            Console.WriteLine();
            }

        // the quick sort method
        public static void Quicksort(int[] elements, int left, int right)
            {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
                {
                while (elements[i].CompareTo(pivot) < 0)
                    {
                    i++;
                    }

                while (elements[j].CompareTo(pivot) > 0)
                    {
                    j--;
                    }

                if (i <= j)
                    {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = (int)tmp;
                    i++;
                    j--;
                    }
                }
            // Recursive calls
            if (left < j)
                {
                Quicksort(elements, left, j);
                }

            if (i < right)
                {
                Quicksort(elements, i, right);
                }
            }

        }
    }