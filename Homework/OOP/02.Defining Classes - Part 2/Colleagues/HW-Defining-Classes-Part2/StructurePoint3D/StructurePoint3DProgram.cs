using System;
using System.Globalization;
using System.Threading;

namespace StructurePoint3D
{
    public class StructurePoint3DProgram
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //Printing BasePoint
            Console.Write("Starting Point: ");
            Console.WriteLine(Point3D.BasePoint);

            // Testing EucledeanDistance
            Point3D randomPoint = new Point3D(1.89M, 6.55M, 7.54M);
            decimal distance = Distance.EucledeanDistance(Point3D.BasePoint, randomPoint);
            Console.WriteLine("Distance between {0} and {1} = {2:F2}", Point3D.BasePoint, randomPoint, distance);

            // Testing Path storage
            // Uncomment this code to test Path Saving
            Path testPath = new Path();
            testPath.AddPoint(Point3D.BasePoint);
            testPath.AddPoint(randomPoint);
            testPath.AddPoint(new Point3D(5.43M, -3.3M, 6.97M));

            PathStorage.SavePath(testPath);

            Console.WriteLine(new String('-', 30));
            Console.WriteLine("Printing Loaded Path:");
            Path loadedPath = PathStorage.LoadPath();
            loadedPath.PrintPath();
  
        }
    }
}
