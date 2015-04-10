using System;
using System.Linq;

namespace _03.DogeCoinsIvaylo
    {
    class DogeCoins
        {
        static void Main()
            {
            // вход от конзолата на две числа с разделител спейс
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0]; //общ брой редове
            int cols = dimensions[1]; // общ брой колони
            int[,] coins = new int[rows, cols]; // нова матрица

            // общ брой стотинки - вход
            int k = int.Parse(Console.ReadLine());

            // координати на стотинки
            for (int i = 0; i < k; i++)
                {
                string[] currentCoords = Console.ReadLine().Split();// прочитаме координати от входа
                int currentCoinRow = int.Parse(currentCoords[0]);//парсваме първо число за ред
                int currentCoinCol = int.Parse(currentCoords[1]);// парсваме второ число за колона
                coins[currentCoinRow, currentCoinCol]++;
                }

            int[,] dp = new int[rows, cols]; // правим нов масив, върху к' ще използваме динамично оптимиране

            //пускаме цикъл, за да търсим в две посоки - надолу и надясно, като намираме 2 стойности:
            for (int row = 0; row < rows; row++)
                {
                for (int col = 0; col < cols; col++)
                    {
                    int maxAbove = 0; //максимална стойност от горе, за вече подмината клетка
                    int maxLeft = 0; // максимална стойност от ляво, за вече подмината клетка
                    if (row - 1 >= 0)
                        {
                        maxAbove = dp[row - 1, col];  //максималната най-горна е равна на ред - 1, колона 
                        }
                    if (col - 1 >= 0)
                        {
                        maxLeft = dp[row, col - 1]; // максималната най-лява е равна на ред, колона - 1
                        }

                    dp[row, col] = Math.Max(maxAbove, maxLeft) + coins[row, col];//резултатът ще е равен на 
                    // по-голямото измежду най-горно и най-ляво + текущата клетка
                    }
                }
            Console.WriteLine(dp[rows - 1, cols - 1]); // принтираме резултата
            }
        }
    }
