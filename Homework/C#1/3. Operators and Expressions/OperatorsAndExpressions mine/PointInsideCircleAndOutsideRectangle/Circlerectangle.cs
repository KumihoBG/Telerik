namespace PointInsideCircleAndOutsideRectangle
{
    using System;
    using System.Globalization;
    using System.Threading;
    class CircleRectangle
    {
        static void Main()
        {
            // Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2);

            CultureInfo en = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = en;
            Console.WriteLine("Please, enter values for \"x\" and \"y\": ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;
            bool withinCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= Math.Pow(r, 2);
            bool outsideRect = ((x < -1) || (x > 5) || (y > 1) || (y < -1));
            bool checkCond = withinCircle && outsideRect;
            Console.WriteLine("The result is: " + checkCond);
        }
    }
}
