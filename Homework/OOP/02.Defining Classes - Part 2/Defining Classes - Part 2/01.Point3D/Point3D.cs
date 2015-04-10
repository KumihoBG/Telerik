//-----------------------------------------------------------------------
// <copyright file="Point3D.cs" company = "Telerik Academy">
// Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _01.Point3D
    {
    using System;
    using System.Text;

    /// <summary>
    /// Constructs a 3D Point
    /// </summary>
    public struct Point3D
        {
        private static readonly Point3D PointO;

        static Point3D()
            {
            PointO = new Point3D(0, 0, 0);
            }

        public Point3D(double x, double y, double z)
            : this()
            {
            this.X = x;
            this.Y = y;
            this.Z = z;
            }

        public static Point3D StartPointO
            {
            get
                {
                return PointO;
                }
            }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
            {
            var result = new StringBuilder();
            result.Append("The 3D Point has the following coordinates: \n");
            result.AppendFormat("X: {0}\n", this.X);
            result.AppendFormat("Y: {0}\n", this.Y);
            result.AppendFormat("Z: {0}\n", this.Z);
            return result.ToString();
            }
        }
    }
