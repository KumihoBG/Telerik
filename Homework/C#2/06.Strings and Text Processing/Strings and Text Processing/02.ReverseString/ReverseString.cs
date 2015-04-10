using System;
using System.Text;

// Write a program that reads a string, reverses it and prints the result at the console;

namespace _02.ReverseString
    {
    class ReverseString
        {
        static void Main()
            {
            // the input
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();

            // printing the result
            Console.WriteLine("This is the reversed version of your input: {0}.", Reverse(text));
            }

        // declaring the reverse method
        static string Reverse(string text)
            {
            var result = new StringBuilder(text.Length);
            for (int i = text.Length - 1; i >= 0; i--)
                {
                result.Append(text[i]); // using StringBuilder requires namespace Text to be added above;
                }
            return result.ToString();
            }
        }
    }
