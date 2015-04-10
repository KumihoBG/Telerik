namespace Trapezoids
{
    using System;
    class Trapezoid
    {
        static void Main()
        {
            // Write an expression that calculates trapezoid's area by given sides a and b and height h;

            Console.WriteLine("Please, enter the values of the trapezoid, namely: a, b and h");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (a + b) * h / 2;
            Console.WriteLine("The area of the trapezoid is: " + area);
        }
    }
}
