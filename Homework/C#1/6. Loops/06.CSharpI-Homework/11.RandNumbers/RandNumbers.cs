using System;

/*
 * Write a program that enters  3  integers  n ,  min  and  max  ( min != max ) and prints  n  random numbers in the range  [min...max] .
*/

class RandNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter min: ");
        int min = int.Parse(Console.ReadLine());

        int max = 0;

        do{

            Console.WriteLine("Enter max: ");

        }while(int.TryParse(Console.ReadLine(),out max)==false || max<=min);

        Random rand = new Random(DateTime.Now.Millisecond);

        Console.WriteLine();
        for (int i = 0; i < numberN;i++)
        {
            Console.Write("{0} ",rand.Next() % (max+1));
        }

        Console.WriteLine();
    }
}

