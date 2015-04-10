using System;
using System.Linq; //without it, the program won't work!

namespace CompareCharArrays
    {
    internal class CompareCharArrays
        {
        private static void Main()
            {
            // Write a program that compares two char arrays lexicographically (letter by letter);
            // after trying to resolve this issue for 30 mins with no result, I googled the problem
            // and found out the existance of the reference System.Linq. I used .SequenceEqual Method to compare
            // and I converted the text directly into char array by calling .ToCharArray() method. Yepi!

            Console.Write("Enter some text here: ");
            char[] text1 = Console.ReadLine().ToCharArray();
            Console.Write("Enter second text to compare if equal to the first one: ");
            char[] text2 = Console.ReadLine().ToCharArray();
            bool equal = text1.SequenceEqual(text2);        //that's doing the whole job! Voila!
            if (text1 == text2)
                {
                Console.WriteLine("Are the char arrays equal? Result: {0}", equal);
                }
            else
                {
                Console.WriteLine("Are the char arrays equal? Result: {0}", equal);
                }
            }
        }
    }
