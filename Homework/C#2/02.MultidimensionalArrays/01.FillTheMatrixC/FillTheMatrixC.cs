using System;
// Write a program that fills and prints a matrix of size (n, n) as shown below;
// {7	11	14	16}
// {4	8	12	15}
// {2	5	9	13}
// {1	3	6	10}

namespace FillTheMatrixC
    {
    class FillTheMatrixC
        {
        static void Main()
            {
            Console.Write("Enter the number of the rows of the matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the columns of the matrix: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            int counter = 1; // the filling number in the cells of the matrix
            int row = matrix.GetLength(0) - 1;
            int col = 0;
            int startRow = matrix.GetLength(0) - 1;
            int startCol = 0;

            while (counter < rows * cols) 
                {
                if (row == (matrix.GetLength(0) - 1) && col < (matrix.GetLength(0) - 1)) //Filling matrix
                    {
                    if (counter == 1) //the start is always 1
                        {
                        matrix[col, row] = counter;
                        }
                    startRow--; 
                    startCol = 0;
                    row = startRow;
                    col = startCol;
                    counter++; 
                    matrix[col, row] = counter;

                    while (row < (matrix.GetLength(0) - 1) && col < (matrix.GetLength(0) - 1))
                        {
                        row++;
                        col++;
                        counter++;
                        matrix[col, row] = counter;
                        }
                    }
                if (row <= (matrix.GetLength(0) - 1) && col == (matrix.GetLength(0) - 1))
                    {
                    startRow = 0;
                    startCol++;
                    row = startRow;
                    col = startCol;
                    counter++;
                    matrix[col, row] = counter;

                    while (col < (matrix.GetLength(1) - 1))
                        {
                        col++;
                        row++;
                        counter++;
                        matrix[col, row] = counter;
                        }
                    }
                }
            for (col = 0; col < cols; col++)           //Printing the matrix
                {
                for (row = 0; row < rows; row++)
                    {
                    Console.Write("{0, 4}", matrix[row, col]);
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            }
        }
    }
