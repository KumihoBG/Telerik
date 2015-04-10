namespace PrintLongSequence
{
    using System;
    class PrintLongSequence
    {
        static void Main()
        {
            // This programs prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
            // using a loop and if-else statement
            for (int i = 2; i <= 1000; i++)
                if ((i % 2) == 0)
                    Console.Write(" {0} ", i);
                else
                    Console.Write(" {0} ", -i);
        }
    }
}
