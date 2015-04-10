using System;
using System.Linq;
using System.Numerics;

// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]);
// Each of the numbers that will be added could have up to 10 000 digits;

namespace _08.NumberAsArray
    {
    class NumberAsArrayMethod
        {
        static void Main()
            {
            // the input
            Console.Write("Enter the first integer positive number: ");
            string numberOne = Console.ReadLine();
            Console.Write("Enter the second integer positive number: ");
            string numberTwo = Console.ReadLine();

            int[] firstArray = new int[numberOne.Length];
            int[] secondArray = new int[numberTwo.Length];

            // calling the method from below
            ToArray(numberOne, firstArray);
            ToArray(numberTwo, secondArray);

            int[] sum = new int[Math.Max(numberOne.Length, numberTwo.Length) + 1];
            if (firstArray.Length > secondArray.Length)
                {
                Array.Copy(secondArray, sum, secondArray.Length);
                SumArrays(sum, firstArray);
                }
            else
                {
                Array.Copy(firstArray, sum, firstArray.Length);
                SumArrays(sum, secondArray);
                }

            Array.Reverse(sum); //reversing
            int i = 0;
            if (sum[i] == 0) i++;
            for (; i < sum.Length; i++)
                {
                Console.Write(sum[i]); // this is how we print the sum
                }
            }

        //declaring two methods - for the sum of the arrays and to create an array
        private static void SumArrays(int[] sum, int[] array1)
            {
            int oneOnMind = 0;
            for (int i = 0; i < array1.Length; i++)
                {
                if ((sum[i] + array1[i] + oneOnMind) > 9)
                    {
                    sum[i] = ((sum[i] + array1[i] + oneOnMind) % 10);
                    oneOnMind = 1;
                    }
                else
                    {
                    sum[i] = ((sum[i] + array1[i] + oneOnMind) % 10);
                    oneOnMind = 0;
                    }
                }
            if (oneOnMind == 1) sum[sum.Length - 1] = 1;
            }
        private static void ToArray(string numberOne, int[] firstArray)
            {
            for (int i = 0, j = numberOne.Length - 1; j >= 0; i++, j--)
                {
                firstArray[i] = numberOne[j] - '0';
                }
            }

        }
    }

