﻿using System;
using System.IO;

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

namespace _07.ReplaceSubString
    {
    class ReplaceSubString
        {
        static void Main()
            {
            using (StreamReader reader = new StreamReader("text.txt"))
                {
                using (StreamWriter output = new StreamWriter("result.txt"))
                    {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                        {
                        string newLine = line.Replace("start", "finish");
                        output.WriteLine(newLine);
                        }
                    }
                }
            Console.WriteLine("Replacing done!");
            }
        }
    }
