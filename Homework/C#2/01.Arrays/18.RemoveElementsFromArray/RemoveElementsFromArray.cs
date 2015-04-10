using System;
using System.Collections.Generic;
using System.Linq;
// Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order;
// Print the remaining sorted array;
// Ex. input = {6, 1, 4, 3, 0, 3, 6, 4, 5}, output = {1, 3, 3, 4, 5}
class RemovedElementsFromArrayAndSort
    {
    static void Main()
        {
        // array input
        Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
        string text = Console.ReadLine();
        char[] space = { ',', ' ' };
        string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

        int[] arr = new int[newStringInput.Length];
        for (int i = 0; i < newStringInput.Length; i++)
            {
            arr[i] = int.Parse(newStringInput[i]);
            }
        List<int> originalList = arr.ToList(); //creating a new list from the array
        List<int> finalList = new List<int>(); // creating a new final list

        int maxValue = (int)Math.Pow(2, originalList.Count) - 1;
        int maxElements = 0;

        for (int i = 1; i <= maxValue; i++)
            {
            List<int> temporaryList = new List<int>(); //creating a temporary list
            int counter = 0;

            for (int j = 1; j <= originalList.Count; j++)
                {
                if (((i >> (j - 1)) & 1) == 1) //using bitwise operation
                    {
                    temporaryList.Add(originalList[j - 1]);
                    counter++;
                    }
                }
            if (counter > maxElements && isSorted(temporaryList))
                {
                finalList = temporaryList;
                maxElements = counter;
                }
            counter = 0;
            }
        PrintList(finalList);
        }
    static bool isSorted(List<int> list)
        {
        bool isSorted = true;

        for (int i = 0; i < list.Count - 1; i++)
            {
            if (list[i] > list[i + 1])
                {
                isSorted = false;
                }
            }
        return isSorted;
        }
    static void PrintList(List<int> list) 
        {
        for (int i = 0; i < list.Count; i++) // printing the sorted list
            {
            Console.Write(list[i] + " ");
            }
        Console.WriteLine();
        }
    }
