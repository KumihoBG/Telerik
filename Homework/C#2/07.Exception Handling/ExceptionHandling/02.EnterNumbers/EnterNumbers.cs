using System;

// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02.EnterNumbers
    {
    class EnterNumbers
        {
        static void Main()
            {
            Console.WriteLine("Enter 10 numbers between 0 and 100, such that each one is smaller than the next one: ");

            // printing the numbers by calling the method from below
            TenNumbers(0, 100);
            }

        // declaring the method to read the numbers
        public static void ReadNumber(int start, int end)
            {
            string input = Console.ReadLine();
            try
                {
                int number = int.Parse(input);
                if (number > start && number < end)
                    {
                    Console.WriteLine("{0} is in range.", number);
                    }
                else
                    {
                    throw new ArgumentOutOfRangeException();
                    }
                }
            catch (ArgumentOutOfRangeException ex)
                {
                Console.WriteLine("Invalid number! \r\n{0}", ex.Message);
                }
            catch (FormatException ex)
                {
                Console.WriteLine("Invalid number! \r\n{0}", ex.Message);
                }
            }

        // declaring the method to print the numbers which calls the reading numbers method itself
        static void TenNumbers(int start, int end)
            {
            for (int i = 0; i < 10; i++)
                {
                ReadNumber(start, end);
                }
            }

        }
    }
