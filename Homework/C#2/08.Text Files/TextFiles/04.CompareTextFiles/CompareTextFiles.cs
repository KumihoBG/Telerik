using System;
using System.Collections.Generic;
using System.IO;

// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
// Assume the files have equal number of lines.

namespace _04.CompareTextFiles
    {
    class CompareTextFiles
        {
        static void Main()
            {
            // reading the two files from ...bin\Debug folder
            StreamReader readerOne = new StreamReader("TextOne.txt");
            StreamReader readerTwo = new StreamReader("TextTwo.txt");

            using (readerOne)
                {
                using (readerTwo)
                    {
                    string linesTextOne = readerOne.ReadLine();
                    string linesTextTwo = readerTwo.ReadLine();
                    int count = 1;

                    // creating lists to store the results
                    List<int> same = new List<int>();
                    List<int> different = new List<int>();

                    while (linesTextOne != null)
                        {
                        if (linesTextOne.Equals(linesTextTwo)) // comparing
                            {
                            same.Add(count);
                            }
                        else
                            {
                            different.Add(count); //adding the result
                            }
                        count++;
                        linesTextOne = readerOne.ReadLine();
                        linesTextTwo = readerTwo.ReadLine();
                        }

                    // printing the result
                    Console.WriteLine("The same lines are: {0}", string.Join(" ", same));
                    Console.WriteLine("These lines are different from each other: {0}", string.Join(" ", different));
                    }
                }
            }
        }
    }
