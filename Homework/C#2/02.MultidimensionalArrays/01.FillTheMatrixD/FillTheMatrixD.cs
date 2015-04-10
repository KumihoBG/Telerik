using System;
// Write a program that fills and prints a matrix of size (n, n) as shown below;
// {1	12	11	10}
// {2	13	16	9}
// {3	14	15	8}
// {4	5	6	7}
namespace FillTheMatrixD
    {
    class FillTheMatrixD
        {
        static void Main()
            {
            // the input
            Console.Write("Enter the number of the rows of the matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the js of the matrix: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            int counter = 1;
            int position = 0;
            int row = 0;
            int col = 0;
            while (counter <= rows * cols)            //Filling the matrix while rows*cols 
                {                                // in oder to be sure that we are not outside the given matrix
                for (row = position; row < rows - position; row++) // printing the side from the left
                    {                                        // and also the inner numbers on the next columns
                    col = position;
                    matrix[row, col] = counter;
                    counter++;
                    }
                for (col = 1 + position; col < cols - position; col++) // printing the side from below
                    {                                         // and also the inner numbers on the next columns
                    row = rows - 1 - position;
                    matrix[row, col] = counter;
                    counter++;
                    }
                for (row = rows - 2 - position; row >= position; row--) // printing the side from the right
                    {                                // and also the inner numbers on the next columns
                    col = cols - 1 - position;
                    matrix[row, col] = counter;
                    counter++;
                    }
                for (col = cols - 2 - position; col >= position + 1; col--) // printing the numbers on the top
                    {                                        // and also the inner numbers on the next columns
                    row = position;
                    matrix[row, col] = counter;
                    counter++;
                    }
                position++;
                }

            for (int i = 0; i < rows; i++)           //Printing the matrix
                {
                for (int j = 0; j < cols; j++)
                    {
                    Console.Write("{0, 4}", matrix[i, j]);
                    }
                Console.WriteLine();
                }
            }
        }
    }