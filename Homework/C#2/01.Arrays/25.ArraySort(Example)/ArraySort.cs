using System;

namespace FrequentNumber
    {
    public abstract class ArraySorting // new class created
        {
        public abstract void Sort(Array array); //here is the Sort method

        private class ArraySort
            {
            private static void Main()
                {
                // We are using the quick sort method Array.Sort instead of Selection sort algorythm;

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


                for (i = 0; i < arr.Length; i++)    // printing the sorted array
                    {
                    if (i != arr.Length - 1)
                        {
                        Console.Write(arr[i] + " ");
                        }
                    else
                        {
                        Console.WriteLine(arr[i]);
                        }
                    }
                }
            }
        }
    }


