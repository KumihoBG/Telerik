//-----------------------------------------------------------------------
// <copyright file="ClassDistance.cs" company = "Telerik Academy">
// Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Point3D
    {
    using System;

    /// <summary>
    /// A static class with a static method which calculates distance between two points - Problem 3
    /// </summary>
    public static class ClassDistance
        {
        /// <summary>
        /// Calculates the distance between two points in 3D space
        /// </summary>
        /// <param name="firstPoint">first point in 3D space</param>
        /// <param name="secondPoint">second point in 3D space</param>
        /// <returns>returns the Euclidean distance</returns>
        public static double CalculateDistance(Point3D p, Point3D q)
            {
            return Math.Sqrt(Math.Pow(p.Y - q.X, 2) + Math.Pow(p.Y - q.Y, 2) + Math.Pow(p.Z - q.Z, 2));
            }
        }
    }
