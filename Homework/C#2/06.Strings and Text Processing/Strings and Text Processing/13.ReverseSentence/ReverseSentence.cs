using System;
using System.Linq;

// Write a program that reverses the words in given sentence;
// Ex. C# is not C++, not PHP and not Delphi!
// Result: Delphi not and PHP, not C++ not is C#!

namespace _13.ReverseSentence
{
    internal class ReverseSentence
    {
        private static void Main()
        {
            // the input
            string text = "C# is not C++, not PHP and not Delphi!";
            char sign = text[text.Length - 1];
            text = text.Remove(text.Length - 1, 1); //using Linq - method Remove

            string[] newSentence = text.Split(' '); // new array created

            var reversed = newSentence.Reverse(); // array is now reversed
            //creating the new reversed sentence
            Console.WriteLine("Reversed sentence:{0}{1}", string.Join(" ", reversed), sign); 
        }
    }
}

