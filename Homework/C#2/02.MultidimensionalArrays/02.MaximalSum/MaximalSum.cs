using System;
// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements;

namespace MaximalSum
    {
    class MaximalSum
        {
        static void Main()
            {
            // the input
            Console.Write("Enter the number of the rows of the matrix: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the js of the matrix: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)           //Filling the matrix
                {
                for (int col = 0; col < m; col++)
                    {
                        Console.Write("matrix[{0},{1}]= ", row, col);
                        matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                }
            // Finding the maximal sum platform of size 3 x 3
            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1]
                        + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                        {
                        bestSum = sum;
                        }
                    }
                }

            for (int row = 0; row < matrix.GetLength(0); row++)       //Printing the matrix
                {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                    Console.Write("{0,4}", matrix[row, col]);
                    }
                Console.WriteLine();
                }
            Console.WriteLine("The sum of max 3x3 is: {0}", bestSum);
            }
        }
    }
