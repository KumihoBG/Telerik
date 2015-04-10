using System;
using System.Collections.Generic;

// Write a program for extracting all email addresses from given text
// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails

namespace _18.ExtractEmails
    {
    internal class Program
        {
        private static void Main()
            {
            // the input
            string text = @"The e-mail address of our office is ""info@gmail.com"".
The e-mail address of our main expert is ""expert@yahoo.com"".";
            Console.WriteLine("Text: {0}", text);
            Console.WriteLine();

            //calling the method and printing
            Console.WriteLine("Extracted e-mails:");
            Console.WriteLine(String.Join("\n", ExtractEmail(text)));
            }

        // declaring a method to extract e-mails
        private static List<string> ExtractEmail(string text)
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
