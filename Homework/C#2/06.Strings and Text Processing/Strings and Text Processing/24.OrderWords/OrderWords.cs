using System;

// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order;

namespace _24.OrderWords
    {
    class OrderWords
        {
        static void Main()
            {
            // the input
            Console.WriteLine("Enter a list of words, separated by spaces: ");
            char[] separator = new char[] { ' ' };
            string[] words = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            // sorting the array
            Array.Sort(words);

            // printing the result
            var sorted = string.Join(" ", words);
            Console.WriteLine("The sorted words: ");
            Console.WriteLine(sorted);
            }
        }
    }
