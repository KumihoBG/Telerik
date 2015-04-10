using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePoint3D
{
    /*
      Problem 4. Path

Create a class Path to hold a sequence of points in the 3D space.
Create a static class PathStorage with static methods to save and load paths from a text file.
Use a file format of your choice.
     */

    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter("../../Saves.txt"))
            {
                foreach (var point in path.AllPoints)
                {
                    writer.WriteLine(point);
                }
                Console.WriteLine("The new path was saved successfully!");
            }
        }

        public static Path LoadPath()
        {
            Path loadPath = new Path();
            using (StreamReader reader = new StreamReader("../../Saves.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    string[] splittedLine = line.Split(
                        new char[] { ' ', '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    loadPath.AddPoint(new Point3D(decimal.Parse(splittedLine[0]), 
                                                  decimal.Parse(splittedLine[1]), 
                                                  decimal.Parse(splittedLine[2])));
                }
                return loadPath;
            }
        }
    }
}
