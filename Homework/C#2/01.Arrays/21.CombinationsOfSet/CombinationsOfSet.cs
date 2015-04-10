using System;
using System.Linq;

// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
// Ex. input:N = 5, K = 2; output:{1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
class CombinationsOfSet
    {
    static void Main()
        {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = Enumerable.Repeat(1, k).ToArray();
        int c;

        do
            {
            c = 1;
            if (isIncreasing(array)) PrintCombinations(array);
            for (int i = 0; i < k; i++)
                {
                array[i] += c;

                if (array[i] <= n)
                    {
                    c = 0; break;
                    }
                else
                    {
                    array[i] = c = 1;
                    }
                }
            }
        while (c != 1);
        }
    static bool isIncreasing(int[] arr)
        {
        for (int i = 0; i < arr.Length; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] <= arr[j])
                    return false;
        return true;
        }
    static void PrintCombinations(int[] arr)
        {
        for (int i = arr.Length - 1; i >= 0; i--)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
        }
    }