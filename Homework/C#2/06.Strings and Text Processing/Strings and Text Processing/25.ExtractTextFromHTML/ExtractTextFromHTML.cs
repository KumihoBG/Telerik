using System;
using System.Text;

// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags

namespace _25.ExtractTextFromHTML
    {
    class ExtractTextFromHTML
        {
        static void Main()
            {
            // the input
            string text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">
Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

            // creating a StringBuilder
            var extract = new StringBuilder();
            bool isText = false;
            bool checkSpace = false;

            // checking the text if it contains tags
            for (int i = 0; i < text.Length - 1; i++)
                {
                if (text[i] == '<')
                    {
                    isText = false;
                    }
                if (isText)
                    {
                    extract.Append(text[i]);
                    }
                if (text[i] == '>')
                    {
                    isText = true;
                    extract.Append(' ');
                    }
                }
            // printing the result
            Console.WriteLine(extract.ToString().Trim());
            }
        }
    }
