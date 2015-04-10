//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x");
        decimal X = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter y");
        decimal Y = decimal.Parse(Console.ReadLine());
        byte radius = 2;
        bool isInCircle = X * X + Y * Y <= radius * radius;
        Console.WriteLine("Is the point in the circle?\n{0}", isInCircle);
    }
}