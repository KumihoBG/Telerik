using System;
// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist);

namespace _05.FirstLargerThanNeighbours
    {
    class LargerThanNeighboursMethod
        {
        static void Main()
            {
            // the input
            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string text = Console.ReadLine();
            char[] space = { ',', ' ' };
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] arrayOfIntegers = new int[newStringInput.Length];
            for (int i = 0; i < newStringInput.Length; i++)
                {
                arrayOfIntegers[i] = int.Parse(newStringInput[i]);
                }

            Console.Write("Enter the position of the number to check for its neighbours: ");
            int theNumber = int.Parse(Console.ReadLine());

            // calling our method from below
            CheckNeighbors(arrayOfIntegers, theNumber);

            }
        // declaring our method
        static void CheckNeighbors(int[] array, int position)
            {
            if (position == 0)
                {
                Console.WriteLine("This is the first element. It has only one neighbour from the right.");
                return;
                }
            if (position == array.Length - 1)
                {
                Console.WriteLine("This is the last element. It has only one neighbour from the left.");
                return;
                }
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
                {
                Console.WriteLine("The given number is bigger than its neibours.");
                return;
                }
            if (array[position] < array[position - 1] && array[position] < array[position + 1])
                {
                Console.WriteLine("The given number is smaller than its neibors.");
                return;
                }
            else Console.WriteLine("The given number is bigger than its left neighbour but smaller than its right number.");
            }
        }
    }
