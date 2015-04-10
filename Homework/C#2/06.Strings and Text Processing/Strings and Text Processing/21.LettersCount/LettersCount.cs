using System;
using System.Collections.Generic;

// Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found;

namespace _21.LettersCount
    {
    class LettersCount
        {
        static void Main()
            {
            // the input
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();

            //creating dictionary to store the result
            var result = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
                {
                if (!result.ContainsKey(text[i]) && char.IsLetter(text[i]))
                    {
                    result.Add(text[i], 1);
                    }
                else if (result.ContainsKey(text[i]) && char.IsLetter(text[i]))
                    {
                    result[text[i]] += 1;
                    }
                }
            Console.WriteLine();

            // printing the result
            foreach (var letter in result)
                {
                Console.WriteLine("The letter {0} is found {1} times in the given text.", letter.Key, letter.Value);
                }
            }
        }
    }
