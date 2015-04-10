using System;
using System.Text;

// Write a program to convert decimal numbers to their binary representation;
// This is a very simple code converting one numeral system to another (Supported bases are 2, 8, 10 & 16):

namespace _01.DecimalToBinary
    {
    class DecimalToBinary
        {
        static void Main()
            {
            // the more-profound way:
            Console.WriteLine("Please enter decimal number:");
            int number = int.Parse(Console.ReadLine());
            StringBuilder list = new StringBuilder();

            while (number != 0)
                {
                list.Append(number % 2);
                number /= 2;
                }

            for (int i = list.Length - 1; i > -1; i--)
                {
                Console.Write(list[i]);
                }
            Console.WriteLine();

            // the lazy way:
            Console.Write("Enter a decimal number to convert: ");
            string decimalNumber = Console.ReadLine();
            int fromBase = 10;
            int toBase = 2;

            var result = Convert.ToString((long)Convert.ToUInt64(decimalNumber, fromBase), toBase);
            Console.WriteLine("The number {0} converted into binary is: {1}", decimalNumber, result);
            }
        }
    }

