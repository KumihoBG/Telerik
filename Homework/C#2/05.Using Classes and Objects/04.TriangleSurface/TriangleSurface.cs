using System;

// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use System.Math.

namespace _04.TriangleSurface
    {
    class TriangleSurface
        {
        private static void Main()
            {
            // asking the user to make a choice:
            Console.WriteLine("Please, make a choice: ");
            Console.WriteLine("1. to find the triangle's area by side and altitude: ");
            Console.WriteLine("2. to find the triangle's area by three sides: ");
            Console.WriteLine("3. to find the triangle's area by two sides and an angle: ");
            int choice = int.Parse(Console.ReadLine());
            const int result = 0;
            switch (choice) // using switch-case to choose the area method
                {
                case 1:
                    //each case has its own input
                    Console.Write("Enter triangle's side: ");
                    double side = int.Parse(Console.ReadLine());
                    Console.Write("Enter triangle's altitude: ");
                    double altitude = int.Parse(Console.ReadLine());
                    Console.WriteLine(Area(side, altitude, result)); // calling the method
                    break;
                case 2:
                    Console.Write("Enter the first side of the triangle: ");
                    double sideOne = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second side of the triangle: ");
                    double sideTwo = int.Parse(Console.ReadLine());
                    Console.Write("Enter the third side of the triangle: ");
                    double sideThree = int.Parse(Console.ReadLine());
                    Console.WriteLine(AreaBySides(sideOne, sideTwo, sideThree, result)); // calling the method
                    break;
                case 3:
                    Console.Write("Enter the first side of the triangle: ");
                    double side1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second side of the triangle: ");
                    double side2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the angle between the two sides of the triangle: ");
                    double angle = int.Parse(Console.ReadLine());
                    Console.WriteLine(AreaBySidesAndAngle(side1, side2, angle, result)); // calling the method
                    break;
                }

            }

        // declaring our methods
        public static double Area(double side, double altitude, double result)
            {
            result = side * altitude / 2; // the formulafor finding the result
            return result;
            }

        public static double AreaBySides(double sideOne, double sideTwo, double sideThree, double result)
            {
            double p = (sideOne + sideTwo + sideThree) / 2; // the formulafor finding the result
            double area = Math.Sqrt((p) * (p - sideOne) * (p - sideTwo) * (p - sideThree));
            return area;
            }

        public static int AreaBySidesAndAngle(double sideOne, double sideTwo, double angle, double result)
            {
            result = (sideOne * sideTwo * Math.Sin(angle * Math.PI / 180)) / 2; // the formulafor finding the result
            return (int)result;
            }
        }
    }


