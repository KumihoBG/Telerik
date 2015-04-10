using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Zerg
    {
    class Zerg
        {
        static void Main()
            {
            string input = Console.ReadLine();

            // creating dictionary
            var letters = new Dictionary<string, char>();
            letters.Add("Rawr", '0');
            letters.Add("Rrrr", '1');
            letters.Add("Hsst", '2');
            letters.Add("Ssst", '3');
            letters.Add("Grrr", '4');
            letters.Add("Rarr", '5');
            letters.Add("Mrrr", '6');
            letters.Add("Psst", '7');
            letters.Add("Uaah", '8');
            letters.Add("Uaha", '9');
            letters.Add("Zzzz", 'A');
            letters.Add("Bauu", 'B');
            letters.Add("Djav", 'C');
            letters.Add("Myau", 'D');
            letters.Add("Gruh", 'E');

            // using the dictionary to convert the input string to hexadecimal digits
            StringBuilder hexNum = new StringBuilder();

            for (int i = 0; i < input.Length; i += 4)
                {
                hexNum.Append(letters[input.Substring(i, 4)]);
                }

            string hNum = hexNum.ToString();

            // hex digits in 15-based numeral system to decimal
            ulong decNum = 0;
            for (int i = 0; i < hNum.Length; i++)
                {
                if (hNum[i] > '9') // if a char digit is > '9', it can only be 'A', 'B', etc. 
                //from the hexadecimal numeral system
                    {
                    decNum += (ulong)(hNum[i] - '7') * (ulong)Math.Pow(15, (hNum.Length - 1 - i));
                    // example: 'A' = 65 (ASCII code); '7' = 55; hence 'A' - '7' = 10, 
                    // which is exactly the decimal representation of the digit A
                    }
                else
                    {
                    decNum += (ulong)(hNum[i] - '0') * (ulong)Math.Pow(15, (hNum.Length - 1 - i));
                    // example: '9' = 57 (ASCII code); '0' = 48; hence '9' - '0' = 9, 
                    // which is exactly the decimal value of the digit 9
                    }
                }

            Console.WriteLine(decNum);
            }
        }
    }

