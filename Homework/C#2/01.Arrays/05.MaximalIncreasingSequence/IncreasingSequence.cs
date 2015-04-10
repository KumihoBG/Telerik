using System;

namespace MaximalIncreasingSequence
    {
    class IncreasingSequence
        {
        static void Main()
            {
            // Write a program that finds the maximal increasing sequence in an array;
            // for ex. {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}
            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string text = Console.ReadLine();
            char[] space = { ',', ' ' };
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[newStringInput.Length];
            for (int i = 0; i < newStringInput.Length; i++)
                {
                arr[i] = int.Parse(newStringInput[i]);
                }
            int counter = 0;
            int maxSequence = 0;
            int index = 0;

            for (int i = 0; i < arr.Length - 1; i++)
                {
                counter = 1;
                int j = i + 1;
                int k = i;

                while (arr[k] + 1 == arr[j])
                    {
                    counter++;
                    j++;
                    k++;
                    if (j >= arr.Length)
                        {
                        break;
                        }
                    }
                if (counter > maxSequence)
                    {
                    maxSequence = counter;
                    index = i;
                    }
                }

            for (int i = index; i <= index + maxSequence - 1; i++)
                {
                if (i != index + maxSequence - 1)
                    {
                    Console.Write(arr[i] + ", ");
                    }
                else
                    {
                    Console.WriteLine(arr[i]);
                    }
                }
            }
        }
    }

