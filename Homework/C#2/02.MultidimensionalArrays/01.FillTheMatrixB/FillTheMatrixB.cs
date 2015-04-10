using System;

// Write a program that fills and prints a matrix of size (n, n) as shown below;
// {1	8	9	16}
// {2	7	10	15}
// {3	6	11	14}
// {4	5	12	13}
namespace FillTheMatrixB
    {
    class FillTheMatrixB
        {
        static void Main()
            {
            Console.Write("Enter the number of the rows of the matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the columns of the matrix: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            int counter = 1; // the filling number in the cells of the matrix

            for (int col = 0; col < matrix.GetLength(1); col++)
                {
                if (col % 2 == 0) // if we have an odd columns, we do the following
                    {
                    for (int row = 0; row < rows; row++) // from zero to the row number
                        {
                        matrix[col, row] = counter; // our matrix fills its cells
                        counter++;  // increasing the counting number on each turn
                        }
                    }
                else  // else, if we have an even columns
                    {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--) // we start from 
                        {                                   // the end of the matrix to zero, decreasing
                        matrix[col, row] = counter;
                        counter++;
                        }
                    }
                }

            for (int col = 0; col < cols; col++)           //Printing the matrix
                {
                for (int row = 0; row < rows; row++)
                    {
                    Console.Write("{0, 4}", matrix[row, col]);
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            }
        }
    }


