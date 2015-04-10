using System;
using System.IO;

/*  Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.
            Example:
            input 	output
            4
            2 3 3 4
            0 2 3 4     17
            3 7 1 2
            4 3 3 2 	    
 */

namespace _05.MaximalAreaSum
    {
    internal class MaximalAreaSum
        {
        private static void Main()
            {
            // reading the matrix from the text file
            const string inputPath = @"..\..\Matrix.txt";

            StreamReader firstFile = new StreamReader(inputPath);

            // findind the result
            using (firstFile)
                {
                var line = firstFile.ReadLine();
                int size = int.Parse(line);
                int[,] matrix = new int[size, size];
                int rows = 0;
                int bestStum = 0;
                while (line != null)
                    {
                    line = firstFile.ReadLine();
                    if (line != null)
                        {
                        string[] str = line.Split(' ');

                        for (int i = rows; i <= rows; i++)
                            {
                            for (int j = 0; j < size; j++)
                                {
                                matrix[i, j] = Int32.Parse(str[j]);
                                }
                            }
                        rows++;
                        }
                    }

                for (int i = 0; i < size - 1; i++)
                    {
                    for (int j = 0; j < size - 1; j++)
                        {
                        int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                        if (sum > bestStum)
                            {
                            bestStum = sum;
                            }
                        }
                    }

                // printing the result
                for (int i = 0; i < size; i++)
                    {
                    for (int j = 0; j < size; j++)
                        {
                        Console.Write(matrix[i, j] + " ");
                        }
                    Console.WriteLine();
                    }
                Console.WriteLine("The maximal sum of 2x2 in the matrix is {0}.", bestStum);
                }
            }
        }
    }
