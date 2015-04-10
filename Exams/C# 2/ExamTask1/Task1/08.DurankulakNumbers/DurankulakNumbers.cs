using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14.DurankulakNumbers
    {
    class DurankulakNumbers
        {
        static void Main()
            {

            string[] digits = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var number = digits.ToString();
            var currLetter = new StringBuilder();
            BigInteger result = 0;
            foreach (var c in number)
                {
                currLetter.Append(c);
                if (digits.Contains(currLetter.ToString()))
                    {
                    int currDigit = Array.IndexOf(digits, currLetter.ToString());
                    result *= 17;
                    result += currDigit;
                    currLetter.Clear();
                    }
                }
            Console.WriteLine(result);
            }
        // method to fill long array with digits
        private static string[] BuildDigits()
            {
            List<string> digits = new List<string>();
            for (char prefix = 'a'; prefix <= 'z'; prefix++)
            {
                string digit = string.Empty;
                digits.Add(digit);
            }
            return digits.ToArray();
            }
        }
    }
