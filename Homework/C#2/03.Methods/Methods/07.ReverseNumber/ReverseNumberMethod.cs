using System;

//Write a method that reverses the digits of given decimal number;
// Ex. input = 256; output = 652;

namespace _07.ReverseNumber
    {
    internal class ReverseNumberMethod
        {
        private static void Main()
            {
            // the input
            Console.Write("Enter some number: ");
            string text = Console.ReadLine();

            //calling our method from below
            Console.WriteLine("The reversed number is: {0}", Reverse(text));
            }
        // declaring our method
        public static string Reverse(string s)
            {
            char[] charArray = s.ToCharArray(); //creating a char array
            Array.Reverse(charArray); //using the Reverse method
            return new string(charArray); //the array is reversed and it is string again
            }
        }
    }
