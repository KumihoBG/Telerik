using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.
/*input	                     output
.NET	                     platform for applications from Microsoft
CLR	                         managed execution environment for .NET
namespace	                 hierarchical organization of classes*/

namespace _14.WordDictionary
    {
    class WordDictionary
        {
        static void Main()
            {
            Console.WriteLine("This is a simple word dictionary: ");
            Console.Write("Check for word: ");
            bool isInDictionary = false;
            string input = Console.ReadLine();

            var dictionary = new Dictionary<string, string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");
           
            foreach (var item in dictionary)
                {
                if (item.Key == input)
                    {
                    Console.WriteLine("The meaning of word {0} is the following: {1}.", input, item.Value);
                    isInDictionary = true;
                    }
                }
            Console.WriteLine(isInDictionary == false ? "This word is not included in the dictionary!" : "");
            }
        }
    }
