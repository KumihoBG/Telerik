using System;

/*
 * Write a program that enters from the console a positive integer  n  and prints all the numbers from  1  to  n , on a single line, separated by a space.
*/

class NumbersFrom1toN
{
    static void Main()
    {
        uint numberN = uint.Parse(Console.ReadLine());

        for (int columnIndex = 0,i = 1; i <= numberN; i++,columnIndex++)
        {
            Console.Write("{0} ", i);

            if (columnIndex == 15)
            {
                Console.Write("\n");
                columnIndex = 0;
            }
            
        }

        Console.Write("\n");

    }
}
