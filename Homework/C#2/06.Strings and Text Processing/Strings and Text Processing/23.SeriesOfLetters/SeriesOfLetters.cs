using System;
using System.Text;

// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one;
// Example: input = aaaaabbbbbcdddeeeedssaa; output = abcdedsa;

namespace _23.SeriesOfLetters
    {
    internal class SeriesOfLetters
        {
        private static void Main()
            {
            // the input
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Your text is: {0}", text);

            // creating a StringBuilder
            StringBuilder sortedList = new StringBuilder();
            sortedList.Append(text[0]);

            //searching 
            for (int i = 0; i < text.Length; i++)
                {
                if (text[i] != sortedList[sortedList.Length - 1])
                    {
                    sortedList.Append(text[i]);
                    }
                }
            // printing the result
            Console.WriteLine("Result: {0}", sortedList);
            }
        }
    }
