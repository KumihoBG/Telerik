using System;
using System.Text;

// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16);

namespace _07.OneSystemToAnyOther
    {
    class OneSystemToAnyOther
        {
        static void Main()
            {
            Console.Write("Enter first numeral system's base (between: 2 < n < 16): ");
            int firstSystem = int.Parse(Console.ReadLine());
            Console.Write("Enter the number to convert: ");
            var number = Math.Abs(long.Parse(Console.ReadLine()));
            Console.Write("Enter the numeral system to which you want to convert that number(between: 2 <s< 16):");
            int secondSystem = int.Parse(Console.ReadLine());

            var newNumber = number;
            var decimalNumber = 0;
            int power = 0;
            while (newNumber > 0)
                {
                int digit = (int)newNumber % 10;
                digit *= (int)Math.Pow(firstSystem, power);
                decimalNumber += digit;
                power++;
                newNumber /= 10;
                }

            StringBuilder str = new StringBuilder();

            while (decimalNumber > 0)
                {
                str.Insert(0, decimalNumber % secondSystem);

                decimalNumber /= secondSystem;
                }
            Console.WriteLine("\n The chosen numeral system was {0}-based and the converted number is the following: {1}", secondSystem, str);
            }
        }
    }
