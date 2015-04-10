using System;

// Write a method that counts how many times given number appears in given array;
// Write a test program to check if the method is workings correctly - check the next testing project for details;

namespace AppearanceCount
    {
    public class AppearanceCountMethod
        {
        public static void Main()
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

            Console.Write("Enter the number to search for: ");
            int theNumber = int.Parse(Console.ReadLine());

            // calling our method from below
            Console.WriteLine("The number appears {0} times in the given array.", CheckForNumber(arrayOfIntegers, theNumber));
            }

        //declaring the method
        public static int CheckForNumber(int[] array, int num)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
                {
                if (array[i] == num) 
                    count++;
                }
            return count;
            }

        }
    }
