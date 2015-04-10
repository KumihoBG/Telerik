using System;

/*
 * Write a program that enters in integer  n  and prints the numbers  1, 2, …, n  in random order.
*/

class RandomizeNumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        int[] numbersSequence = new int[numberN];
 
        for(int i = 1;i <= numberN;i++)
        {
            numbersSequence[i - 1] = i; 
        }

        Random rand = new Random(DateTime.Now.Millisecond);
        int randIndex = 0;

        for (int i = 0; i < numberN;)
        {
            randIndex = rand.Next() % numberN;

            if (numbersSequence[randIndex] != 0)
            {
                Console.Write("{0} ", numbersSequence[randIndex]);
                numbersSequence[randIndex] = 0;
                i++;
            }
        }

        Console.WriteLine();
    }
}

