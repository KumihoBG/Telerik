// Problem 4. Rectangles

// Write an expression that calculates rectangle’s perimeter and area by given width and height.
// Examples:

// width	height	perimeter  area
// 3	    4	    14	       12
// 2.5	    3	    11         7.5
// 5	    5       20         25

using System;

class Rectangles
{
    static void Main()
    {
        double height, wight;
        Console.Write("Enter the height of the rectange:");
        bool isValidHeight = double.TryParse(Console.ReadLine(), out height);
        Console.Write("Enter the wight of the rectange:");
        bool isValidWight = double.TryParse(Console.ReadLine(), out wight);
        if (isValidHeight && isValidHeight)
        {
            double area = height * wight;
            Console.WriteLine("The area of the rectange is:{0}", area);
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}
