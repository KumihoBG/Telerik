using System;
using System.Text;

// Write a program to convert binary numbers to their decimal representation;

namespace _02.BinaryToDecimal
    {
    class BinaryToDecimal
        {
        static void Main()
            {
            // *************************************** the harder way:
            Console.WriteLine("Please enter binary number:");
            string number = Console.ReadLine();
            int decNumber = 0;
            int index = 0;

            for (int i = number.Length - 1; i >= 0; i--)
                {
                decNumber += (int)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
                index++;
                }

            Console.WriteLine(decNumber);
            Console.Write("Enter a binary number to convert: ");
            string binaryNumber = Console.ReadLine();

            //**************************************** the lazy way:
            int fromBase = 2;
            int toBase = 10;

            var result = Convert.ToString((long)Convert.ToUInt64(binaryNumber, fromBase), toBase);
            Console.WriteLine("The number {0} converted into decimal is: {1}", binaryNumber, result);
            }
        }
    }
