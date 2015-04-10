using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _12.StrangeLandNumbers
    {
    class StrangeLandNumbers
        {
        static void Main()
            {
            // creating a string array to fill with the strange system
            string[] alpha = { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
            // the input
            var input = Console.ReadLine();
            // creating a stringbuilder to store the current letter
            var currLetter = new StringBuilder();
            // the result should be BigInteger, meaning the example output
            BigInteger result = 0;
            //using foreach we are looping the input
            foreach (var c in input)
                {
                currLetter.Append(c); //and appending the stringbuilder with every char
                if (alpha.Contains(currLetter.ToString())) //if the chars make some of the strings in the array
                    {
                    int currDigit = Array.IndexOf(alpha, currLetter.ToString()); // if so, we take the 
                    result *= 7;  // finding the result                  // index of the element in the 
                    result += currDigit; //we add the index to the result              // string array
                    currLetter.Clear(); // we clear and start again
                    }
                }
            Console.WriteLine(result);
            }
        }
    }
