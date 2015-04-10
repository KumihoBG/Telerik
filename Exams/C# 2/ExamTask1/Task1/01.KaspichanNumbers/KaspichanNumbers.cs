using System;
using System.Collections.Generic;

namespace _01.KaspichanNumbers
    {
    class KaspichanNumbers
        {
        static void Main()
            {
            ulong inputNumber = ulong.Parse(Console.ReadLine());
            string[] alpha = BuildDigits();

            // Convert the input decimal number to number in 256 base system)
            List<string> kaspichanNumbers = new List<string>();
            do
                {
                kaspichanNumbers.Add(alpha[inputNumber % 256]);
                inputNumber /= 256;
                }
            while (inputNumber != 0);

            kaspichanNumbers.Reverse(); // Reversing the number to get the real value
            string result = string.Join(string.Empty, kaspichanNumbers);

            Console.WriteLine(result);
            }
        // method to fill long array with digits
        private static string[] BuildDigits()
            {
            List<string> digits = new List<string>();
            for (char digit = 'A'; digit <= 'Z'; digit++)
                {
                digits.Add("" + digit);
                }
            for (char prefix = 'a'; prefix <= 'z'; prefix++)
                {
                for (char suffix = 'A'; suffix <= 'Z'; suffix++)
                    {
                    string digit = "" + prefix + suffix;
                    digits.Add(digit);
                    }
                }
            return digits.ToArray();
            }
        }
    }

