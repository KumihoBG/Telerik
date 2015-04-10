using System;

/*
 * Write a program that reads from the console a sequence of  n  integer numbers and returns the minimal, the maximal number,
 * the sum and the average of all numbers (displayed with 2 digits after the decimal point).
 * The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
 * The output is like in the examples below.
*/

class AverageNNumbers
{
    static void Main()
    {
        int min = int.MaxValue, max = 0, sum = 0;

        int count = int.Parse(Console.ReadLine());

        for(int number = 0,i = 0;i < count;i++)
        {
            number = int.Parse(Console.ReadLine());

            if (number < min) { min = number; }
            if (number > max) { max = number; }
            sum += number;
        }

        double average = ((double)sum / (double)count);

        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("average = {0:F2}", average);
    }
}
