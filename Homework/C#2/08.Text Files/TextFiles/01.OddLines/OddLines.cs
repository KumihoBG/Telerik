using System;
using System.IO;

// Write a program that reads a text file and prints on the console its odd lines.

namespace _01.OddLines
    {
    class OddLines
        {
        static void Main()
            {
            string fileName = "Test.txt";
            Console.WriteLine("The contents of the file {0} is the following:", fileName);
            Console.WriteLine();
            StreamReader streamReader = new StreamReader(fileName);

            using (streamReader)
                {
                string fileContents = streamReader.ReadToEnd();
                Console.WriteLine(fileContents);
                }

            Console.WriteLine("Now reading only the odd lines:");
            Console.WriteLine();
            StreamReader reader = new StreamReader(fileName);
            using (reader)
                {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                    {
                        if (lineNumber++ % 2 != 0)
                        {
                        lineNumber++;
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                        line = reader.ReadLine();
                        }                   
                    }
                }
            }
        }
    }
