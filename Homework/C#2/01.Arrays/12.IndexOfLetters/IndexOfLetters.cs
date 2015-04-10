// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
    {
    static void Main()
        {
        int index;
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); //creating char array of letters

        Console.Write("Please, enter a word: ");
        string word = Console.ReadLine().Trim().ToUpper();  // String.Trim - Removes all leading and trailing white-space characters from the current String object.

        foreach (char c in word)
            {
            index = (int)c - (int)'A'; //that's the formula for finding the index
            Console.Write("{0} ", index);
            }
        Console.WriteLine();
        }
    }