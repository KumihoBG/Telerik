using System;

/*
 * Write a program that enters from the console a positive integer  n  and prints all the numbers from  1  to  n  not divisible by  3  and  7 , on a single line, separated by a space.
*/

class DivisibleBy3n7
{
    static void Main()
    {
        uint numberN = uint.Parse(Console.ReadLine());

        for (int columnIndex = 0, i = 1; i <= numberN; i++)
        {
            if((i % 3)>0 && (i % 7)>0) {

                Console.Write("{0} ", i);
                columnIndex++;

                if (columnIndex == 15)
                {
                    Console.Write("\n");
                    columnIndex = 0;
                }
            }

        }

        Console.Write("\n");
    }
}

