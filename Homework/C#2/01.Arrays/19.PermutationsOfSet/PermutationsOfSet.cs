using System;

namespace PermutationsOfSet
    {
    class Permutation
        {
        static void Main()
            {
            Console.Write("Enter the number N: ");
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[number];
            for (int i = 0; i < arr.Length; i++)
                {
                arr[i] = i + 1;
                }
            Perm(arr, 0, arr.Length - 1);
            }
        private static void Perm(int[] arr, int k, int n)
            {
            if (k == n)
                {
                Print(arr);
                }
            else
                {
                for (int i = k; i <= n; i++)
                    {
                    SwapElements(arr, k, i);
                    Perm(arr, k + 1, n);
                    SwapElements(arr, k, i);
                    }
                }
            }
        private static void SwapElements(int[] arr, int k, int i)
            {
            int t = arr[k];
            arr[k] = arr[i];
            arr[i] = t;
            }
        private static void Print(int[] arr)
            {
            for (int i = 0; i < arr.Length; i++)
                {
                Console.Write(arr[i] + " ");
                }
            Console.WriteLine();
            }
        }

    }