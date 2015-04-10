using System;
using System.Linq;

// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.

namespace _06.SumIntegers
    {
    class SumIntegers
        {
        static void Main()
            {
            Console.Write("Enter a sequence of positive integer values, separated by spaces: ");
            string input = Console.ReadLine();

            // calling and printing the method's result
             Console.WriteLine("The sum of the entered numbers is: {0}", Sum(input)); 
            }

        // declaring the function (the method)
        private static int Sum(string input)
            {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            return array.Sum(); //using Linq, the .Sum() method
             }
        }
    }
