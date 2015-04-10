using System;

/*
 * Write a program that reads from the console a positive integer number  n  (1 = n = 20)
 * and prints a matrix holding the numbers from  1  to  n*n  in the form of square spiral like in the examples below.
*/


class SpiralMatrix
{
    enum spiralDirections { right, down, left, up };

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        int[,] spiralMatrix = new int[numberN,numberN];
 
        spiralDirections direction = spiralDirections.right;

        int index = 1, maxIterations = numberN * numberN;
        int row = 0, col = 0;
        int addRow = 0, addCol = 1;

        while(index <= maxIterations)
        {
            while (row >= 0 && col >=0 && row < numberN && col < numberN && spiralMatrix[row,col]==0)
            {
                spiralMatrix[row, col] = index;
                row += addRow;
                col += addCol;

                index++;
            }

            row -= addRow;
            col -= addCol;

            switch (direction)
            {
                case spiralDirections.right:
                    {
                        addRow = 1;
                        addCol = 0;
                        direction = spiralDirections.down;
                        break;
                    }
                case spiralDirections.down:
                    {
                        addRow = 0;
                        addCol = -1;
                        direction = spiralDirections.left;
                        break;
                    }
                case spiralDirections.left:
                    {
                        addRow = -1;
                        addCol = 0;
                        direction = spiralDirections.up;
                        break;
                    }
                case spiralDirections.up:
                    {
                        addRow = 0;
                        addCol = 1;
                        direction = spiralDirections.right;
                        break;
                    }
            }

            row += addRow;
            col += addCol;

        }

        for(int i = 0;i < numberN;i++)
        {
            for (int j = 0; j < numberN; j++)
            {
                Console.Write("{0,3}", spiralMatrix[i,j]);
            }

            Console.WriteLine();
        }
    }

}

