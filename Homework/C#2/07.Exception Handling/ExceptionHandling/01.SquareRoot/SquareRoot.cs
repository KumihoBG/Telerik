using System;

// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print Invalid number.
// In all cases finally print Good bye.
// Use try-catch-finally block.
namespace _01.SquareRoot
    {
    class SquareRoot
        {
        static void Main()
            {
            // the input
            Console.WriteLine("Enter a number to calculate its square root: ");
            int number = int.Parse(Console.ReadLine());

            // try - catch - finally
            try
                {
                SqrtOfNumber(number);
                Console.WriteLine("The square root of the number {0} is {1}.", number, SqrtOfNumber(number));
                }
            catch (ArgumentOutOfRangeException ex)
                {
                Console.WriteLine("Invalid number!");
                throw;
                }
            catch (FormatException ex)
                {
                Console.WriteLine("Invalid number!");
                throw;
                }
            finally
                {
                Console.WriteLine("Good bye!");
                }
            }


        // declaring a method to find Square root of a number
        private static double SqrtOfNumber(double number)
            {
            if (number < 0)
                {
                throw new ArgumentOutOfRangeException();
                }
            return Math.Sqrt(number);
            }
        }
    }
