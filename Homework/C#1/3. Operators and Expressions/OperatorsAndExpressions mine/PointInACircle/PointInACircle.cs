using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            // Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2);
            Console.WriteLine("Please, enter values for \"x\" and \"y\": ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool isPointInCircle = Math.Sqrt(x * x + y * y) <= 2; // using Pythagorean Theorem (a2 + b2 = c2);
            Console.WriteLine(isPointInCircle);
        }
    }
}
