﻿using System;
using System.Linq;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
// Ex. input:N = 3, K = 2; output:{1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
class VariationsOfSet
    {
    static void Main()
        {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        // Initialize the array with ones 'k' times 
        int[] array = Enumerable.Repeat(1, k).ToArray();
        int c;
        do
            {
            c = 1;
            PrintElements(array);

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
    static void PrintElements(int[] arr)
        {
        for (int i = arr.Length - 1; i >= 0; i--)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
        }
    }