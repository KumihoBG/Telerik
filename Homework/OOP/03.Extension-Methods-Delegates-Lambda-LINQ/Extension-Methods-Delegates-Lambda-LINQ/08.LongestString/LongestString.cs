// Write a program to return the string with maximum length from an array of strings.
// Use LINQ.
namespace _08.LongestString
    {
    using System;
    using System.Linq;

    /// <summary>
    /// A class for sorting strings using LINQ
    /// </summary>
    class LongestString
        {
        /// <summary>
        /// The main method
        /// </summary>
        static void Main()
            {
            string[] someStrArray =
            {
                "Strawberry",
                "Banana",
                "Horse",
                "Telephone number",
                "Mouse and cat running around.",
                "I love my husband and my kid. Family is most important thing in the world."
            };

            var sortedWordsByLenght = someStrArray
                .OrderByDescending(s => s.Length)
                .FirstOrDefault();

            if (sortedWordsByLenght != null)
                foreach (var word in sortedWordsByLenght)
                {
                    Console.Write(word);
                }
            Console.WriteLine();
            }
        }
    }
