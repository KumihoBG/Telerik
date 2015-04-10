using System;

namespace StructurePoint3D
{    
    /*
      Problem 1. Structure

Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
Implement the ToString() to enable printing a 3D point.
      */
    public struct Point3D
    {
        /* 2.Add a private static read-only field to hold 
        the start of the coordinate system – the point O{0, 0, 0}. 
        Add a static property to return the point O */
        private static readonly Point3D basePoint = new Point3D(0, 0, 0);

        // Constructor
        public Point3D(decimal x, decimal y, decimal z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // static property
        public static Point3D BasePoint
        {
            get { return basePoint; }
        }

        // Properties
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public decimal Z { get; set; }


        // ToString override
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }

    }
}
