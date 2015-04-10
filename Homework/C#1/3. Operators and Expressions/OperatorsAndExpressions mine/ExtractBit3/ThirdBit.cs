namespace ExtractBit3
{
    using System;
    class ThirdBit
    {
        static void Main()
        {
            // Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer;
            // The bits are counted from right to left, starting from bit #0;
            // The result of the expression should be either 1 or 0;

            Console.WriteLine("Please, enter a number to find its third bit value: ");
            uint myNumber = uint.Parse(Console.ReadLine());
            uint thirdBit = (myNumber >> 3) & 1;
            Console.WriteLine("The third bit of " + myNumber + " is " + thirdBit);
        }
    }
}
