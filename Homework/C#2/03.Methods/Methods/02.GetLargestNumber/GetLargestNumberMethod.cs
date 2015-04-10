using System;

// Write a method GetMax() with two parameters that returns the larger of two integers
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()

namespace GetLargestNumber
    {
    class GetLargestNumberMethod
        {
        static void Main()
            {
            Console.Write("Enter the first integer number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer number: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter the third integer number: ");
            int third = int.Parse(Console.ReadLine());
            int max = GetMax(GetMax(first, second), third);
            Console.WriteLine("The largest number is {0}.", max);
            }

        private static int GetMax(int first, int second)
            {
            if (first > second)
                {
                return first;
                }
            else if (second > first)
                {
                return second;
                }
            return first;
            }
        }
    }
