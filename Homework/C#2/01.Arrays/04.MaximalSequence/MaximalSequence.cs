using System;

namespace MaximalSequence
    {
    class MaximalSequence
        {
        static void Main()
            {
            // Write a program that finds the maximal sequence of equal elements in an array;
            Console.Write("Enter the input numbers of the array, separated by comma and/or space: ");
            string input = Console.ReadLine(); // the input numbers as a string
            char[] split = { ',', ' ' };       // we split the string by chars
            string[] text = input.Split(split, StringSplitOptions.RemoveEmptyEntries);  // new string[]
            int[] newArray = new int[text.Length];  // we initialize a new int aray 
            for (int i = 0; i < text.Length; i++)   // setting the array lenght
                {
                    newArray[i] = int.Parse(text[i]);
                }
            int maxSequence = 0;
            int start = 0;
            for (int i = 0; i < newArray.Length; i++)   // starting the loop to check all elements
                {
                int currentNumber = 0;                  // every time loops is cyrcling the number gets 0
                int j = i;                              // initializing second array

                while (newArray[i] == newArray[j]) //using while to be sure that the 2nd array will be in range
                    {
                    currentNumber++;
                    j++;
                    if (j >= newArray.Length)   // if out of range --> break
                        {
                        break;
                        }
                    }

                if (currentNumber > maxSequence)    
                    {
                    maxSequence = currentNumber;
                    start = i; 
                    }
                }
            // after the loop check all elements in the array new loop must print them
            for (int i = start; i <= start + maxSequence - 1; i++)
                {
                if (i != start + maxSequence - 1)
                    {
                    Console.Write(newArray[i] + ", "); // with comma between elements
                    }
                else
                    {
                    Console.WriteLine(newArray[i]); // printing the last element with no comma
                    }
                 }
            }
        }
    }

