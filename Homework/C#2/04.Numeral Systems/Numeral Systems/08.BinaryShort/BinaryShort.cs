using System;

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short);
// short (from -32,768 to 32,767) - Signed 16-bit integer - System.Int16

namespace _08.BinaryShort
    {
    class BinaryShort
        {
        static void Main()
            {
            Console.Write("Enter a short integer number: ");
            short n;
            short.TryParse(Console.ReadLine(), out n);
            Console.Write("The binary representation of the number is: ");
            Console.WriteLine(Convert.ToString(n, 2));
            }
        }
    }
