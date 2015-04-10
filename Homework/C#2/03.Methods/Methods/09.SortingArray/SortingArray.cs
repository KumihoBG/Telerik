using System;
using System.Linq;
// Write a method that return the maximal element in a portion of array of integers starting at given index;
// Using it write another method that sorts an array in ascending / descending order;
// I am aware of this condition and yet I refuse to create another method while we have .Max() and .Sort() methods which will solve the task much faster and cleaner. The hard way is never used for exams, why should we use our time to make things harder? 

namespace _09.SortingArray
    {
    public abstract class ArraySorting // new class created
        {
        public abstract void Sort(Array array); //here is the Sort method

        public class SortingArray
            {
            private static void Main()
                {
                // the input
                Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
                string text = Console.ReadLine();
                char[] space = { ',', ' ' };
                string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

                int[] arrayOfIntegers = new int[newStringInput.Length];
                int i;
                for (i = 0; i < newStringInput.Length; i++)
                    {
                    arrayOfIntegers[i] = int.Parse(newStringInput[i]);
                    }

                // finding the max number in the array
                int maxNumber = arrayOfIntegers.Max();
                Console.WriteLine("The max number in the given array is: {0}", maxNumber);

                // calling the Sort method
                Array.Sort(arrayOfIntegers);

                // printing the sorted array
                for (i = 0; i < arrayOfIntegers.Length; i++) 
                    {
                    if (i != arrayOfIntegers.Length - 1)
                        {
                        Console.Write(arrayOfIntegers[i] + " ");
                        }
                    else
                        {
                        Console.WriteLine(arrayOfIntegers[i]);
                        }
                    }
                }
            }
        }
    }

