using System;

namespace FrequentNumber
    {
    public abstract class ArraySorting // I decided to sort the array first, that's not necessary though
        {
        public abstract void Sort(Array array); //here is the Sort method

        public class FrequentNumber
            {
            private static void Main()
                {
                // Write a program that finds the most frequent number in an array;
                // Ex.{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} --> {4 (5 times)}

                Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
                string text = Console.ReadLine();
                char[] space = { ',', ' ' };
                string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

                int[] arr = new int[newStringInput.Length];
                int i;
                for (i = 0; i < newStringInput.Length; i++)
                    {
                    arr[i] = int.Parse(newStringInput[i]);
                    }
                Array.Sort(arr);    // calling the Sort method

                int currentElement = 1;
                int bestElement = 0;
                int index = 0;

                for (i = 0; i < arr.Length - 1; i++) //using a loop to check all array elements
                    {
                    for (int j = 1; j < arr.Length; j++) //using nested loop to check the next array elements
                        {
                        if (arr[i] == arr[j])   // when we find equal elements, we start to count them
                            {
                            currentElement++;
                            }
                        }
                    if (currentElement > bestElement) //we compare what's found
                        {
                        bestElement = currentElement; //and we store it in a separate variable
                        index = i;
                        }
                    currentElement = 0; //then we reset the current element
                    }
                Console.WriteLine(arr[index] + " (" + bestElement + ") times");
                }
            }
        }
    }


