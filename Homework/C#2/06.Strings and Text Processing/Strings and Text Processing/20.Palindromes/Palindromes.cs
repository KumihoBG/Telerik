using System;
using System.Text;

// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe;
// A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward. Allowances may be made for adjustments to capital letters, punctuation, and word dividers.

namespace _20.Palindromes
    {
    internal class Palindromes
        {
        private static void Main()
            {
            // the input
            string text =
                " Some words: exe, rar, beer, ABBA, cat, radar, dog, level, rotor\n, place, kayak, reviver, racecar, redder, sir, madam";
            Console.WriteLine("The text is: {0}", text);
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            // searching and printing the result
            Console.WriteLine("The palindromes are:");
            foreach (var word in words)
                {
                StringBuilder list = new StringBuilder(); //using StringBuilder
                for (int i = word.Length - 1; i >= 0; i--)
                    {
                    list.Append(word[i]);
                    }

                if (word == list.ToString())
                    {
                    Console.WriteLine(word);
                    }
                }
            }
        }
    }
