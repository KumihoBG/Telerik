using System;

namespace StructurePoint3D
{
    /*
      Problem 3. Static class

    Write a static class with a static method to calculate 
    the distance between two points in the 3D space.
     */
    public static class Distance
    {
        // d(p, q) = sqrt{(p_1 - q_1)^2 + (p_2 - q_2)^2 + (p_3 - q_3)^2}
        public static decimal EucledeanDistance(Point3D a, Point3D b)
        {
            decimal result =
                Sqrt((Power((a.X - b.X), 2) + Power((a.Y - b.Y), 2) + Power((a.Z - b.Z), 2)));

            return result;
        }

        public static decimal Power(decimal number, decimal power)
        {
            decimal result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        public static decimal Sqrt(decimal number)
        {
            decimal x = number / 2;

            for (int i = 0; i < 100; i++)
            {
                x = (x + number / x) / 2M;
            }
            return x;
        }
    }
}
