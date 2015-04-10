namespace BitsExchange
{
    using System;
    class BitsExchange
    {
        static void Main()
        {
            // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer;
            // Tools we will need: bitwise AND (&), bitwise OR (|), left shift (<<), and right shift (>>);
            Console.WriteLine("Please, enter a number:");
            UInt32 myNumber = UInt32.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation of your number is {0}", Convert.ToString(myNumber, 2).PadLeft(32, '0') + ".");
            Console.WriteLine("Now, let's exchange 3, 4 and 5th bits of this number with 24, 25, 26th bits of the same number!");

            uint mask = 7;
            uint firstGroup = (myNumber & (mask << 3)) >> 3; // Cuts bits 3, 4 and 5, and puts them back to the beginning
            uint secondGroup = (myNumber & (mask << 24)) >> 24; // Cuts bits 24, 25 and 26, and puts them back to the beginning 
            myNumber = myNumber & ~(mask << 3);
            myNumber = myNumber & ~(mask << 24);
            myNumber = myNumber | (firstGroup << 24);
            myNumber = myNumber | (secondGroup << 3);

            Console.WriteLine("The result is: {0}", myNumber);
            Console.WriteLine("The binary representaion of the newly created number is: {0}", Convert.ToString(myNumber, 2).PadLeft(32, '0'));
        }
    }
}
