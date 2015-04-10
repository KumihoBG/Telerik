using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Task4Template
{
    internal class Task4
    {
        private static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            string searchWord = Console.ReadLine().ToLower().Trim();

            string[] paragraphs = new string[n];
            for (int i = 0; i < searchWord.Length; i++)
                {
                paragraphs[i] = Console.ReadLine();
                }
            char[] separators = new char[]{' ', '.', '{', '}', '\n', ':', ';'};

            string[] words = searchWord.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            

            StringBuilder result = new StringBuilder();

            
            //Console.WriteLine("Methods -> {0}", methods);
            //Console.WriteLine("Loops -> {0}", loops);
            //Console.WriteLine("Conditional Statements -> {0}", conditional);
            //}
        }
        private static List<string> ExtractWords(string text)
            {
            var emails = new List<string>();
            string[] email = text.Split(new char[] { '"', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in email)
                {
                if (word.Contains("@"))
                    {
                    emails.Add(word);
                    }
                }
            return emails;
            }
    }
}

