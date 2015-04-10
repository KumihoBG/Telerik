//-----------------------------------------------------------------------
// <copyright file="Point3DMain.cs" company = "Telerik Academy">
// Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Point3D
    {
    using System;

    /// <summary>
    /// Public class Structure
    /// </summary>
    public static class Structure
        {
        /// <summary>
        /// The Main method
        /// </summary>
        public static void Main()
            {
            Point3D pointOne = Point3D.StartPointO;
            Point3D pointTwo = new Point3D(5, 9, 20);
            Console.WriteLine("The distance between the the points is the following: {0}", ClassDistance.CalculateDistance(pointOne, pointTwo));

            Path path = new Path();
            path.AddPoint(pointOne);
            path.AddPoint(pointTwo);
            Console.WriteLine(path);

            PathStorage.Save(path, "input.txt");
            Console.WriteLine(PathStorage.Load("output.txt"));
            Console.WriteLine(PathStorage.Load("output.txt"));
            }
        }
    }
