//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.
//Examples:
//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int Number = int.Parse(Console.ReadLine());
        bool even = ((Number % 2) != 0);
        Console.WriteLine(even);
    }
}

