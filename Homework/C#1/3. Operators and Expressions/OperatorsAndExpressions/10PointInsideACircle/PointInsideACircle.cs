//Problem. 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the 
//rectangle R(top=1, left=-1, width=6, height=2).
using System;

class PointInsideACircle
{
    static void Main()
  { 
        Console.WriteLine("Enter x");
        decimal X = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter y");
        decimal Y = decimal.Parse(Console.ReadLine());
        decimal radius = 1.5m;
        bool isInCircle = (X - 1) * (X - 1) + (Y - 1) * (Y - 1) <= radius * radius;
        if (isInCircle && Y > 1)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
   }
}
