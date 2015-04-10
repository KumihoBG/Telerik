using System;

// Write a program that generates and prints to the console 10 random values in the range [100, 200]

namespace _02.RandomNumbers
    {
    class RandomNumbers
        {
        static void Main()
            {
            Random randomNumbers = new Random(); //should be outside the loop for taking an effect

            for (int numbers = 1; numbers <= 10; numbers++)
                {
                Console.WriteLine("Number {0} -> Value {1}", numbers, randomNumbers.Next(100,201));
                }
            }
        }
    }
