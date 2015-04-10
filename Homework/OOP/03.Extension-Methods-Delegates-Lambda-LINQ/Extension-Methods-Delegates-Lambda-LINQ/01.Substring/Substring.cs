//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String

namespace _01.Substring
{
    using System;

    /// <summary>
    /// A substring extension method
    /// </summary>
    public static class Substring
    {
        /// <summary>
        /// The main method of the program
        /// </summary>
        public static void Main()
        {
            const string HelloMethod = "Hello, new substring extension method!";
            var newSubstring = HelloMethod.SubstringNew(7, 31);
            Console.WriteLine("This is the " + newSubstring);
        }

        /// <summary>
        /// Public static extension method
        /// </summary>
        /// <param name="input">string input</param>
        /// <param name="startIndex">integer index</param>
        /// <param name="length">integer lenght</param>
        /// <returns>new substring</returns>
        public static string SubstringNew(this string input, int startIndex, int length)
        {
            // Todo: Check that startIndex + length does not cause an arithmetic overflow
            {
                if (startIndex > input.Length - 1)
                {
                    throw new ArgumentException("Start index cannot be greater than string length.", "startIndex");
                }

                return startIndex + length > input.Length ? input.Substring(startIndex) : input.Substring(startIndex, length);
            }
        }
    }
}
