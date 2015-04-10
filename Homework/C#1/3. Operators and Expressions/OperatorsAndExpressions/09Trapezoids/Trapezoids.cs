//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;


class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter a:");
        decimal sideA = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        decimal sideB = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter h:");
        decimal heightH = decimal.Parse(Console.ReadLine());
        decimal area = ((sideA + sideB) / 2) * heightH;
        Console.WriteLine("The area is: " + area);
    }
}

