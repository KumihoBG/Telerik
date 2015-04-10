namespace CheckABitAtGivenPosition
{
    using System;
    class CheckBit
    {
        static void Main()
        {
            // Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1;
            Console.WriteLine("Please, enter the integer number: ");
            int numberN = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter the position: ");
            int indexP = int.Parse(Console.ReadLine());

            Console.WriteLine("Now, let's see if the bit at the given position has a value of \"1\": ");
            int mask = 1 << indexP; // creating the mast to guarantee the expected result
            int nAndMask = numberN & mask; // applying the mask to our number
            int bit = nAndMask >> indexP; // applying the result to the given position
            if (bit == 1) // boolean expression
            {
                Console.WriteLine("True! The bit at the given position is indeed \"1\"!");
            }
            else
            {
                Console.WriteLine("False, this bit is \"0\"!");
            }
        }
    }
}
