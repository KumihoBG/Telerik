using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _13._9GagNumbers
    {
    class _9GagNumbers
        {
        static void Main()
            {
            string[] alpha = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
            var input = Console.ReadLine();
            var currLetter = new StringBuilder();
            BigInteger result = 0;
            foreach (var c in input)
                {
                currLetter.Append(c);
                if (alpha.Contains(currLetter.ToString()))
                    {
                    int currDigit = Array.IndexOf(alpha, currLetter.ToString());
                    result *= 9;
                    result += currDigit;
                    currLetter.Clear();
                    }
                }
            Console.WriteLine(result);
            }
        }
    }

