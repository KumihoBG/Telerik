using System;
using System.Collections.Generic;

// Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found

namespace _22.WordsCount
    {
    class WordsCount
        {
        static void Main()
            {
            // the input
            Console.WriteLine("Enter some text: ");
            string input = Console.ReadLine();
            string[] text = input.Split(new[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            //creating dictionary to store the result
            var dictionary = new Dictionary<string, int>();

            //sorting the array
            Array.Sort(text);

            // searching and counting
            for (int i = 0; i < text.Length; i++)
                {
                int counter = 0;
                foreach (var word in text)
                    {
                    if (word == text[i])
                        {
                        counter++;
                        }
                    }
                if (!dictionary.ContainsKey(text[i]))
                    {
                    dictionary.Add(text[i], counter);
                    }
                }

            // printing the result
            foreach (var pair in dictionary)
                {
                Console.WriteLine("The word {0} is found {1} times.", pair.Key, pair.Value);
                }
            }
        }
    }
