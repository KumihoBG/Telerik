using System;
using System.Linq;
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#)

namespace _15.NumberCalculations
    {
    class NumberCalculations
        {
        static void Main()
            {
            // the input;
            Console.WriteLine("Enter the different number types values, separated by space or comma, as follows: ");
            Console.Write("Enter decimal numbers: ");
            decimal[] decimals = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            Console.Write("Enter float numbers: ");
            float[] floats = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
            Console.Write("Enter byte numbers: ");
            byte[] bytes = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            Console.Write("Enter double numbers: ");
            double[] doubles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.Write("Enter long integers: ");
            long[] longs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            Console.WriteLine();
            
            // you can use the following example:
            //decimal[] deci = new decimal[] { 2.4, 5.8888, 7.123 };
            //float[] floa = new float[] { 9.2, 3.4444, 9.123 };
            //byte[] byt = new byte[] { 2, 9, 4 };
            //double[] doub = new double[] { 56.1, 12.33333, 45.2222 };
            //long[] lon = new long[] { 818237482, 65715291911, 71122171718 };

            // calling the methods from below:
            Calculate(decimals);
            Calculate(floats);
            Calculate(bytes);
            Calculate(doubles);
            Calculate(longs);
            }

        //declaring the minimum value method
        private static T GetMinimumValue<T>(params T[] array) where T : IComparable<T>
            {
            Array.Sort(array);

            return array[0];
            }

        //declaring the maximum value method
        private static T GetMaximumValue<T>(params T[] array) where T : IComparable<T>
            {
            Array.Sort(array);

            return array[array.Length - 1];
            }

        //declaring the avarage value method
        private static double GetAverageValue<T>(params T[] array)
            {
            return Convert.ToDouble(GetSum(array)) / array.Length;
            }

        //declaring the sum value method
        private static dynamic GetSum<T>(params T[] array)
            {
            dynamic sum = 0;

            for (int i = 0; i < array.Length; i++)
                {
                sum += array[i];
                }

            return sum;
            }

        //declaring the product value method
        private static dynamic GetProduct<T>(params T[] array)
            {
            dynamic product = 1;

            for (int i = 0; i < array.Length; i++)
                {
                product *= array[i];
                }

            return product;
            }

        //declaring the calculation method
        private static void Calculate<T>(params T[] array)
            {
            dynamic arrForUse = array;

            var min = GetMinimumValue(arrForUse);
            var max = GetMaximumValue(arrForUse);
            var sum = GetSum(arrForUse);
            var average = GetAverageValue(arrForUse);
            var product = GetProduct(arrForUse);

            Console.WriteLine("The minimum is : {0}", min);
            Console.WriteLine("The maxmimum is : {0}", max);
            Console.WriteLine("The sum is : {0}", sum);
            Console.WriteLine("The average amount is : {0}", average);
            Console.WriteLine("The product is : {0}", product);
            Console.WriteLine();
            }
        }
    }
