using System;

/*
 * Write a program that reads from the console a positive integer number  n  (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
*/

class MatrixOfNumbers
{
    static void Main()
    {
        int N = 0;

        do{
            Console.WriteLine("Enter N between 1 and 20: ");

        }while(int.TryParse(Console.ReadLine(), out N)==false || N<1 || N>20);

        for (int x = 0;x < N;x++)
        {
            for (int i = 1+x;i <= N+x;i++)
            {
                Console.Write("{0,2} ",i);
            }

            Console.Write("\n");
        }
    }
}

