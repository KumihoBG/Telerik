// Merge sort is a sorting algorithm which is based on Divide-and-conquer paradigm. The algorithm divides the array in two halves in each step and recursively calls itself on the two halves. And then merges two sorted halves. The mergeArray() function is used to merge two sorted arrays.
using System;
class MergeSortMethod
    {
    private static void Main()
        {
        // input from the console:
        Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
        string text = Console.ReadLine();
        char[] space = { ',', ' ' };
        string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

        int[] unsortedArray = new int[newStringInput.Length];
        int i;
        for (i = 0; i < newStringInput.Length; i++)
            {
            unsortedArray[i] = int.Parse(newStringInput[i]);
            }

        //callind the method MergeSort from below
        MergeSort(ref unsortedArray, 0, unsortedArray.Length - 1);
        foreach (int element in unsortedArray)
            {
            Console.Write(" " + element);
            }
        Console.Read();

        }
    private static void MergeSort(ref int[] unsortedArray, int leftIndex, int rightIndex)
        {
        if (leftIndex < rightIndex)
            {
            int middleIndex = (leftIndex + rightIndex) / 2;
            //Sort left (will call Merge to produce a fully sorted left array)
            MergeSort(ref unsortedArray, leftIndex, middleIndex);
            //Sort right (will call Merge to produce a fully sorted right array)
            MergeSort(ref unsortedArray, middleIndex + 1, rightIndex);
            //Merge the sorted left & right to finish off.
            Merge(unsortedArray, leftIndex, middleIndex, rightIndex);
            }
        }
    private static void Merge(int[] unsortedArray, int leftIndex, int middleIndex, int rightIndex)
        {
        int lengthLeft = middleIndex - leftIndex + 1;
        int lengthRight = rightIndex - middleIndex;
        int[] leftArray = new int[lengthLeft + 1];
        int[] rightArray = new int[lengthRight + 1];
        for (int i = 0; i < lengthLeft; i++) // checking the left half of the array
            {
            leftArray[i] = unsortedArray[leftIndex + i];
            }
        for (int j = 0; j < lengthRight; j++)   // checking the right half of the array
            {
            rightArray[j] = unsortedArray[middleIndex + j + 1];
            }
        leftArray[lengthLeft] = Int32.MaxValue;
        rightArray[lengthRight] = Int32.MaxValue;
        int iIndex = 0;
        int jIndex = 0;
        for (int k = leftIndex; k <= rightIndex; k++)
            {
            if (leftArray[iIndex] <= rightArray[jIndex])
                {
                unsortedArray[k] = leftArray[iIndex];
                iIndex++;
                }
            else
                {
                unsortedArray[k] = rightArray[jIndex];
                jIndex++;
                }
            }
        }
    }