using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePoint3D
{
    /*
      Problem 4. Path

Create a class Path to hold a sequence of points in the 3D space.
Create a static class PathStorage with static methods 
    to save and load paths from a text file.
Use a file format of your choice.
     
     */
    public class Path
    {
        public readonly List<Point3D> AllPoints = new List<Point3D>();

        public void AddPoint(Point3D point)
        {
            this.AllPoints.Add(point);
        }

        public void ClearPath()
        {
            this.AllPoints.Clear();
        }

        public void PrintPath()
        {
            foreach (var point in AllPoints)
            {
                Console.WriteLine("({0}, {1}, {2})", point.X, point.Y, point.Z);
            }
        }
    }
}
