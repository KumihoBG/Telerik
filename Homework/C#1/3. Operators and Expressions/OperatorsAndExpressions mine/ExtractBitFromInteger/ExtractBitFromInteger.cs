namespace ExtractBitFromInteger
{
    using System;
    class ExtractBitFromInteger
    {
        static void Main()
        {
            // Write an expression that extracts from given integer n the value of given bit at index p;

            Console.WriteLine("Please, enter the integer number: ");
            int numberN = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter the position: ");
            int indexP = int.Parse(Console.ReadLine());

            int mask = 1 << indexP; // creating a mask to guarantee the result
            int nAndMask = numberN & mask; // applying the mask to our number
            int bit = nAndMask >> indexP; // applying that result to the given position
            Console.WriteLine("The bit of the number {0} at the given position {1} ", numberN, indexP + " is " + bit + ".");
        }
    }
}
