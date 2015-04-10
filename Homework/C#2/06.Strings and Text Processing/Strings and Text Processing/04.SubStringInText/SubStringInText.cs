using System;

// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search);

namespace _04.SubStringInText
{
    internal class SubStringInText
    {
        private static void Main()
        {
            Console.WriteLine("Enter some text to search for element: ");
            string text = Console.ReadLine().ToLower();
            // The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

            Console.WriteLine("Enter the sub-string element in the given text: ");
            string element = Console.ReadLine().ToLower();
            // The target sub-string is "in"

            int count = 0;
            for (int i = 0; i < text.Length - 1; i++)
                {
                if (text.Substring(i, element.Length).ToLower() == element)
                    {
                    count++;
                    i += element.Length;
                    }
                }
            Console.WriteLine("The result is:{0}", count);
        }
    }
}
