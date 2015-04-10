using System;
using System.Text;
// Write a program to convert decimal numbers to their hexadecimal representation;

namespace _03.DecimalToHexadecimal
    {
    class DecimalToHexadecimal
        {
        static void Main()
            {
            // the hard way:
            Console.Write("Enter decimal number to convert: ");
            int number = int.Parse(Console.ReadLine());
            StringBuilder list = new StringBuilder();

            while (number != 0)
                {
                if (number % 16 > 9)
                    {
                    switch (number % 16)
                        {
                        case 10: list.Append("A");
                            break;
                        case 11: list.Append("B");
                            break;
                        case 12: list.Append("C");
                            break;
                        case 13: list.Append("D");
                            break;
                        case 14: list.Append("E");
                            break;
                        case 15: list.Append("F");
                            break;
                        }
                    }
                else
                    {
                    list.Append((number % 16).ToString());
                    }
                number /= 16;
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
            int toBase = 16;

            var result = Convert.ToString((long)Convert.ToUInt64(decimalNumber, fromBase), toBase);
            Console.WriteLine("The number {0} converted into hexadecimal is: {1}", decimalNumber, result.ToUpper());
            }
        }
    }
