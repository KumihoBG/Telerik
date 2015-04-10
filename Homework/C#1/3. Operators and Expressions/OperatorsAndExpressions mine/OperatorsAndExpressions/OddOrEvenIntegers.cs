namespace OperatorsAndExpressions
{
    using System;
    class OddOrEvenIntegers
    {
        static void Main()
        {
            // Write an expression that checks if given integer is odd or even;

            Console.WriteLine("Please, enter a number to check whether it is even or odd:");
            int number = int.Parse(Console.ReadLine());
            if (number%2 == 0)
            {
                Console.WriteLine("The number is even! --> True!");
            }
            else
            {
                Console.WriteLine("The number is odd! --> False!");
            }
        }
    }
}
