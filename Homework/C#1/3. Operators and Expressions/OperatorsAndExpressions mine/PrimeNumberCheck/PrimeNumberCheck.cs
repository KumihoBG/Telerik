namespace PrimeNumberCheck
{
    using System;
    class PrimeNumberCheck
    {
        static void Main()
        {
            // Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1);

            Console.WriteLine("Please, enter an integer number! Must be a positive one!");
            int positiveNumber = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(positiveNumber);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (positiveNumber % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Is this number prime? {0}", prime);
        }
    }
}
