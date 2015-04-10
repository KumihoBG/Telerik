using System;
// Write a program to convert hexadecimal numbers to their decimal representation;

namespace _04.HexadecimalToDecimal
    {
    class HexadecimalToDecimal
        {
        static void Main()
            {
            // the hard way:
            Console.Write("Please enter decimal number (use Caps Lock): ");
            string number = Console.ReadLine();
            int decNumber = 0;
            int index;
            int j = 0;

            for (int i = number.Length - 1; i >= 0; i--)
                {
                switch (number[i])
                    {
                    case 'A': index = 10;
                        break;
                    case 'B': index = 11;
                        break;
                    case 'C': index = 12;
                        break;
                    case 'D': index = 13;
                        break;
                    case 'E': index = 14;
                        break;
                    case 'F': index = 15;
                        break;
                    default: index = int.Parse(number[i].ToString());
                        break;
                    }
                decNumber += index * (int)Math.Pow(16, j);
                j++;
                }
            Console.WriteLine(decNumber);

            // the lazy way:
            Console.Write("Enter a hexadecimal number to convert (no need to use Caps Lock: ");
            string hexaNumber = Console.ReadLine();
            int fromBase = 16;
            int toBase = 10;

            var result = Convert.ToString((long) Convert.ToUInt64(hexaNumber, fromBase), toBase);
            Console.WriteLine("The number {0} converted into decimal is: {1}", hexaNumber, result);
            }
        }
    }
