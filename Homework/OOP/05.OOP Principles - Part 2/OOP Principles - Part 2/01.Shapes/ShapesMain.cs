/* Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array. */

namespace _01.Shapes
    {
    using System;
    using System.Collections.Generic;

    public class ShapesMain
        {
        public static void Main()
            {
            // creating new instances of each shape
            var shapes = new List<Shape>()
            {
                new Rectangle(6, 8),
                new Square(8),
                new Triangle(2, 3)
            };

            // printing the area for each shape
            foreach (var shape in shapes)
                {
                Console.WriteLine(shape.GetType().Name + " area: " + shape.CalculateSurface());
                }
            }
        }
    }
