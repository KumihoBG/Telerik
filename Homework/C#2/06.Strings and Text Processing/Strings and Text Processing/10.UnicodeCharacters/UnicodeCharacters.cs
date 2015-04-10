using System;

// Write a program that converts a string to a sequence of C# Unicode character literals;
// Use format strings;
// Ex. input = Hi! output = \u0048\u0069\u0021;
namespace _10.UnicodeCharacters
    {
    class UnicodeCharacters
        {
        static void Main()
            {
            // the input
            Console.WriteLine("Enter some text: ");
            char[] input = Console.ReadLine().ToCharArray();

            Console.WriteLine("The result in Unicode characters is the following: ");

            // the conversion with a loop cycle
            for (int i = 0; i < input.Length; i++)
                {
                Console.Write("\\{0:X4}", ((int)input[i]));
                }
            Console.WriteLine();
            }
        }
    }
