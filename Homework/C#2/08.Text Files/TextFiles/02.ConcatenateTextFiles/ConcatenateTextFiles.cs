using System;
using System.IO;

// Write a program that concatenates two text files into another text file;

namespace _02.ConcatenateTextFiles
    {
    class ConcatenateTextFiles
        {
        static void Main()
            {
            const string pathFileOne = "../../ReadingFileOne.txt";
            const string pathFileTwo = "../../ReadingFileTwo.txt";
            const string pathFinalText = "../../FinalText.txt";

            //calling methods from below
            ReadFiles(pathFileOne, pathFinalText);
            ReadFiles(pathFileTwo, pathFinalText);

            PrintFinalTextFile(pathFinalText);
            }

        // declaring a method to read files
        static void ReadFiles(string pathText, string pathResult)
            {
            using (StreamWriter result = new StreamWriter(pathResult, true))
                {
                using (StreamReader reader = new StreamReader(pathText))
                    {
                    while (!reader.EndOfStream) result.WriteLine(reader.ReadLine());
                    }
                }
            }

        // declaring a method to print the result
        static void PrintFinalTextFile(string path)
            {
            Console.WriteLine("> This is the concatenated text file:\n");

            using (StreamReader reader = new StreamReader(path))
                {
                while (!reader.EndOfStream) Console.WriteLine(reader.ReadLine());
                }

            Console.WriteLine("\n> Concatenation completed!\n");
            }
        }
    }
