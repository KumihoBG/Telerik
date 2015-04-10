using System;
using System.IO;

// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

namespace _03.LineNumbers
    {
    class LineNumbers
        {
        static void Main()
            {
            // creating a new reader to read the original file
            StreamReader reader = new StreamReader(@"..\..\SomeTextFile.txt");

            using (reader)
                {
                string line = reader.ReadLine();

                // creating a writer to put the lines into the original file
                StreamWriter writer = new StreamWriter(@"..\..\FinalText.txt");
                int lineNum = 0;
                using (writer)
                    {
                    while (line != null)
                        {
                        lineNum++;
                        writer.WriteLine("Line {0}: {1}", lineNum, line);
                        line = reader.ReadLine();
                        }
                    }
                }

            // reading the final text file
            Console.WriteLine("The text has lines now:");
            Console.WriteLine();
            using (StreamReader resultReader = new StreamReader(@"..\..\FinalText.txt"))
                {
                while (!resultReader.EndOfStream) Console.WriteLine(resultReader.ReadLine());
                }
            }
        }
    }
