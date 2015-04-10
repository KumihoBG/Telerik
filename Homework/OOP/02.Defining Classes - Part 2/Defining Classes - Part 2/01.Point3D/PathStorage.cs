//-----------------------------------------------------------------------
// <copyright file="PathStorage.cs" company = "Telerik Academy">
// Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;
using _01.Point3D;
using IO = System.IO;

public static class PathStorage
    {
    public static void Save(Path path, string pathName)
        {
        string fullPath = IO.Path.Combine("input.txt");
        using (IO.StreamWriter writer = IO.File.CreateText(fullPath))
            {
            writer.Write(path);
            }
        }

    public static Path Load(string pathName)
        {
        Path path = new Path();
        string fullPath = IO.Path.Combine("output.txt");

        try
            {
            using (IO.StreamReader reader = new IO.StreamReader(fullPath))
                {
                string[] allPoints = reader.ReadToEnd()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var point in allPoints)
                    {
                    double[] coordinates = point.Trim('{').Trim('}')
                        .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => double.Parse(x))
                        .ToArray();

                    path.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    }
                }
            }
        catch (IO.FileNotFoundException)
            {
            Console.Write("The file \"{0}\" cannot be found.", pathName);
            return null;
            }

        return path;
        }
    }
