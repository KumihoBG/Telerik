﻿using System;
using System.Collections.Generic;
using System.IO;

// Write a program that deletes from given text file all odd lines.
// The result should be in the same file.

namespace _09.DeleteOddLines
    {
    class DeleteOddLines
        {
        static void Main()
            {
            List<string> evenLines = new List<string>();
            using (StreamReader reader = new StreamReader(@"..\..\SomeTextFile.txt"))
                {
                int lineNum = 1;
                string line = reader.ReadLine();
                while (line != null)
                    {
                    if (lineNum % 2 == 0)
                        {
                        evenLines.Add(line);
                        }
                    lineNum++;
                    line = reader.ReadLine();
                    }
                }
            using (StreamWriter output = new StreamWriter(@"..\..\SomeTextFile.txt"))
                {
                for (int i = 0; i < evenLines.Count; i++)
                    {
                    output.WriteLine(evenLines[i]);
                    }
                }
            Console.WriteLine("Odd lines removed!");
            }
        }
    }
