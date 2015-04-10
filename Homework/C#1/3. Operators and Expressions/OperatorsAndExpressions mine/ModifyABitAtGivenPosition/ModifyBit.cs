namespace ModifyABitAtGivenPosition
{
    using System;
    class ModifyBit
    {
        static void Main()
        {
            // We are given an integer number n, a bit value v (v=0 or 1) and a position p;
            // Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n;
            Console.WriteLine("Please, enter the integer number: ");
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please, enter the value (\"0\" or \"1\"):");
            int valueV = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please, enter the position: ");
            int indexP = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (valueV == 0)
            {
                numberN = (numberN & ~(1 << indexP));
            }
            else
            {
                numberN = numberN | (1 << indexP);
            }
            Console.WriteLine("The new binary representation of your number {0} is : {1}", numberN, Convert.ToString(numberN, 2).PadLeft(16, '0'));
            Console.WriteLine("Result: {0}", numberN);            
        }
    }
}
