using System;

namespace AllocateArray
    {
    class Program
        {
        static void Main()
            {
            // Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5;
            int[] arrayOf20 = new int[20]; // max element number is 20 but the array lenght actually is 0-19
            for (int i = 0; i < arrayOf20.Length; i++) // initializing array's elements' values, using loop
            {
                arrayOf20[i] = i;                      // array lenght is equal to the array's index
                int result = i*5;                      //multiplying every element of the array by 5
                Console.Write(result + " ");           // printing the result
            }
            }
        }
    }
