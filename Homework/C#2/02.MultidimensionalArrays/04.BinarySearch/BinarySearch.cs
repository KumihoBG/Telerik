using System;
// Write a program, that reads from the console an array of N integers and an integer value, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ value
public abstract class SortArray
    {
    public abstract void Sort(Array array); //here is the Sort method
    }
namespace BinarySearch
    {
    class BinarySearch
        {
        static void Main()
            {
            // the input
            Console.Write("Enter the array's lenght: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the max value: ");
            int value = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[n];
            int maxValue = 0;
            for (int i = 0; i < n; i++)
                {
                Console.Write("Array[{0}]= ", i);
                numbersArray[i] = int.Parse(Console.ReadLine());
                }

            Array.Sort(numbersArray); //callind the sorting method from above

            for (int i = 0; i < numbersArray.Length; i++)
                {

                if (numbersArray[i] < value)
                    {
                    maxValue = numbersArray[i];
                    }
                }
            Array.BinarySearch(numbersArray, maxValue); // the Array.BinarySearch method

            if (numbersArray[0] > value) // printing the result
                {
                Console.WriteLine("The given value is smaller than any number in the array.");
                }
            else
                {
                Console.WriteLine("The max value was {0}. The next bigger number after the given max value is: {1}", value, maxValue);
                }
            }
        }
    }
