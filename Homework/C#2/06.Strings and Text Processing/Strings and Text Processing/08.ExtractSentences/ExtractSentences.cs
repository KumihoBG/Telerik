using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// Write a program that extracts from a given text all sentences containing given word;
// Example: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
// The word is: in.

namespace _08.ExtractSentences
    {
    class ExtractSentences
        {
        static void Main()
            {
            Console.WriteLine("Enter some text:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter a word from the text:");
            string substring = Console.ReadLine();
            string word = substring + " ";

            StringBuilder result = new StringBuilder();

            string[] text = input.Split('.', '!', ',', ';');
            for (int i = 0; i < text.Length; i++)
                {
                if (text[i].Contains(word))
                    {
                    result.Append(text[i] + ".");
                    }
                }
            Console.WriteLine("The result is:{0}", result);
            Console.WriteLine();
            }
        }
    }

