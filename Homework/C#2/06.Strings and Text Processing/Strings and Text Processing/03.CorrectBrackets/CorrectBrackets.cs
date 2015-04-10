using System;

// Write a program to check if in a given expression the brackets are put correctly;
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b));

namespace _03.CorrectBrackets
    {
    internal class CorrectBrackets
        {
        private static void Main()
            {
            // the input
            Console.WriteLine("Enter the expression to check if it is correct: ");
            string text = Console.ReadLine();

            // printing the method
            Console.WriteLine("Is it correct? {0}", ExtractBrackets(text));

            }

        // declaring a boolean method to check the expression
        static bool ExtractBrackets(string text)
            {
            int bracketsCounter = 0; //starting to count the brackets
            if (text[0].ToString() == ")") // if the zero index is ")" the result will be false
            {
                return false;
            }
            for (int i = 0; i < text.Length; i++) // else we start a cicle to count the brackets
                {
                if (text[i].ToString() == "(")
                    {
                    bracketsCounter++;
                    }
                else if (text[i].ToString() == ")")
                    {
                    bracketsCounter--;
                    }
                }
            if (bracketsCounter == 0) // we must be sure that the brackets are not less than a zero position
                {
                return true;
                }
            return false;
            }
        }
    }
