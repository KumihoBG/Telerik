using System;
using System.Numerics;

/*
 * Write a program that calculates with how many zeroes the factorial of a given number  n  has at its end.
 * Your program should work well for very big numbers, e.g.  n=100000 .
*/

class TrailingZeroes
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        int factorFive = 5;
        int trailingZeroes = 0;

        while (true)
        {
            if (numberN / factorFive < 1)
            {
                break;
            }

            trailingZeroes += numberN / factorFive;

            factorFive *= 5;
        }

        Console.WriteLine("Number of trailing zeroes: {0}", trailingZeroes);

        if (numberN > 1000)
        {

            char answer;

            do{

                Console.WriteLine("Calculating and displaying the factorial will take long time for bigger numbers, do you wish to proceed ? (y/n)");
                answer = (char) Console.Read();
                Console.ReadLine();

            }while(answer!='y' && answer!='n');

            if(answer=='n')
            {
                return;
            }
        }

        BigInteger factorial = 1;

        for (int i = 0; i < numberN; )
        {
            factorial *= numberN;
            numberN--;
        }

        Console.WriteLine(factorial);
    }
}

