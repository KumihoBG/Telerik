using System;

// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

namespace _15.ReplaceTags
    {
    class ReplaceTags
        {
        static void Main()
            {
            // the input
            string input = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.";
            Console.WriteLine("The input string: ");
            Console.WriteLine(input);
            
            // replacing
            input = input.Replace("<a href=\"", "[URL=");
            input = input.Replace("</a>", "[/URL]");
            input = input.Replace("\">", "]");

            // printing
            Console.WriteLine();
            Console.WriteLine("The result: ");
            Console.WriteLine(input);
            }
        }
    }
