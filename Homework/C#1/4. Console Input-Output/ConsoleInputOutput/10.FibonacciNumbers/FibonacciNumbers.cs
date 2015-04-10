namespace FibonacciNumbers
{
    using System;

    internal class FibonacciNumbers
    {
        private static void Main()
        {
            // Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
            Console.WriteLine("Please, enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < number; i++)
            {
                int c = a + b;              
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}
