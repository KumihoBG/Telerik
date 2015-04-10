using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation;
// Format the output aligned right in 15 symbols;

namespace _11.FormatNumber
    {
    class FormatNumber
        {
        static void Main()
            {
            Console.WriteLine("Enter some number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Printing the number: ");
            Console.WriteLine("As decimal:                {0,15:D}", number);
            Console.WriteLine("As hexadecimal:            {0,15:X}", number);
            Console.WriteLine("As percentage:             {0,15:P0}", number);
            Console.WriteLine("As scientific notation:    {0,14:E2}", number);
            }
        }
    }
