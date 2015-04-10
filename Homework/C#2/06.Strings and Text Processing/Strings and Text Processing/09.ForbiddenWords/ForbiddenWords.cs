using System;
using System.Text;

// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.
//Example: @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
// words: PHP, CLR, Microsoft;

namespace _09.ForbiddenWords
    {
    class ForbiddenWords
        {
        static void Main()
            {
            //the input
            Console.WriteLine("Enter some text to replace the forbidden words in it: ");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the forbidden words: ");
            string forbiddenWords = Console.ReadLine().ToLower();
            char[] separators = {',', ' '};
            string[] forbiddenWordsArr = forbiddenWords.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //finding the forbidden words
            for (int i = 0; i < forbiddenWordsArr.Length; i++)
                {
                // creating new string builder to store the new text
                StringBuilder newText = new StringBuilder();
                newText.Append('*', forbiddenWordsArr[i].Length); //replacing the forbidden words with *
                text = text.Replace(forbiddenWordsArr[i], newText.ToString()); //replacing the input
                }
            Console.WriteLine("The text with the replaced forbidden words is the following:");
            Console.WriteLine(text);

            }
        }
    }
