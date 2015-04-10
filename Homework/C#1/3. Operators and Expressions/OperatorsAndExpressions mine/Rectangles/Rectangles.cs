namespace Rectangles
{
    using System;
    class Rectangles
    {
        static void Main()
        {
            // Write an expression that calculates rectangle’s perimeter and area by given width and height;

            Console.WriteLine("Please, enter the width of the rectangle:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Now, enter its height:");
            double b = double.Parse(Console.ReadLine());
            double area = a*b;
            double perimeter = (2*a) + (2*b);
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
            Console.WriteLine("The area of the rectangle is: {0}", area);
        }
    }
}
