using System;

namespace CompareArrays
    {
    class CompareArrays
        {
        private static void Main()
            {
            // Write a program that reads two integer arrays from the console and compares them element by element;
            Console.Write("Enter first array's lenght: ");
            int numberInputOne = int.Parse(Console.ReadLine());
            Console.Write("Enter second's array lenght: ");
            int numberInputTwo = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[numberInputOne];   // initializing the number one array's lenght
            int[] arrayTwo = new int[numberInputTwo];   // initializing the number two array's lenght
            bool comparer = true;
            Console.WriteLine("Enter the values of the first array, each on a separate line: ");
            for (int i = 0; i < numberInputOne; i++)
                {
                arrayOne[i] = int.Parse(Console.ReadLine());    // initializing the values of the first array;
                }
            Console.WriteLine("Now enter the values of the second array, each on a separate line: ");
            for (int i = 0; i < numberInputTwo; i++)
                {
                arrayTwo[i] = int.Parse(Console.ReadLine());    // initializng the values of the second array;
                }
            for (int i = 0; i < arrayOne.Length; i++)           // comparing the arrays using nested loop
                {                                               // and if-else statement
                for (int j = 0; j < arrayTwo.Length; j++)
                    {
                    if (arrayOne[i] == arrayTwo[i] && numberInputOne == numberInputTwo) // comparing array's 
                        {                                                               // lenght and values!
                        comparer = true;                        // arrays are equal;
                        }
                    else
                        {
                        comparer = false;                       // arrays are not equal;
                        }
                    }
                }
            Console.WriteLine("Are these arrays equal? {0}", comparer);
            }
        }
    }
