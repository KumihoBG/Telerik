using System;

// Write a program that fills and prints a matrix of size (n, n) as shown below;
// {1	5	9	13}
// {2	6	10	14}
// {3	7	11	15}
// {4	8	12	16}
namespace FillTheMatrix
    {
    class FillTheMatrix
        {
        static void Main()
            {
            Console.Write("Enter the number of the rows of the matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the columns of the matrix: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            int counter = 1; // using a counter to fill the cells of the matrix
            
            for (int row = 0; row < matrix.GetLength(0); row++) // by rows
            {
                for (int col = 0; col < matrix.GetLength(1); col++) // by columns
                {
                matrix[row, col] = counter; // increasing the counter to fill it on each turn of the loop
                counter++; 
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++) // Printing the matrix
                {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write("{0,4}", matrix[col, row]);
                    }
                Console.WriteLine();
                }
            }
        }
    }
