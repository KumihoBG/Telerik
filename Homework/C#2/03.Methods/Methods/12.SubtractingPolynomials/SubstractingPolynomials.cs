using System;
// Extend the previous program to support also subtraction and multiplication of polynomials;

namespace _12.SubtractingPolynomials
    {
    class SubstractingPolynomials
        {
        static void Main()
            {
            // the input
            decimal[] firstPolynomial = { 15, -4 };
            Console.Write("First polynomial: ");
            PrintPolynomial(firstPolynomial);

            decimal[] secondPolynomial = { 8, -15, 5 };
            Console.Write("Second polynomial: ");

            //calling the printing method
            PrintPolynomial(secondPolynomial);

            int maxLength = 0;
            if (firstPolynomial.Length > secondPolynomial.Length)
                {
                maxLength = firstPolynomial.Length;
                }
            else
                {
                maxLength = secondPolynomial.Length;
                }

            decimal[] result = new decimal[maxLength];

            // calling the sum method
            Sum(firstPolynomial, secondPolynomial, result);

            Console.Write("The sum of the two polynomials is: ");
            PrintPolynomial(result);

            // calling the substraction method
            Substract(firstPolynomial, secondPolynomial, result);
            Console.Write("The substraction result is: ");
            PrintPolynomial(result);

            decimal[] multiply = new decimal[firstPolynomial.Length + secondPolynomial.Length];

            // calling the multiplication method
            Multiply(firstPolynomial, secondPolynomial, multiply);
            Console.Write("The multiplication result is: ");
            PrintPolynomial(multiply);
            }

        // declaring a method for multiplication
        static void Multiply(decimal[] first, decimal[] second, decimal[] result)
            {
            for (int i = 0; i < result.Length; i++)
                {
                result[i] = 0;
                }

            for (int i = 0; i < first.Length; i++)
                {
                for (int j = 0; j < second.Length; j++)
                    {
                    int position = i + j;

                    result[position] += (first[i] * second[j]);
                    }
                }
            }

        // declaring a method for substraction
        static void Substract(decimal[] first, decimal[] second, decimal[] result)
            {
            int minLenght = 0;
            int smallerPoly = 0;

            if (first.Length > second.Length)
                {
                minLenght = second.Length;
                smallerPoly = 2;
                }
            else
                {
                minLenght = first.Length;
                smallerPoly = 1;
                }

            for (int i = 0; i < minLenght; i++)
                {
                result[i] = first[i] - second[i];
                }

            for (int i = minLenght; i < result.Length; i++)
                {
                if (smallerPoly == 1)
                    {
                    result[i] = -second[i];
                    }
                else
                    {
                    result[i] = first[i];
                    }
                }
            }

        // declaring a method for addition of polynomials
        static void Sum(decimal[] first, decimal[] second, decimal[] result)
            {
            int minLenght = 0;
            int smallerPoly = 0;

            if (first.Length > second.Length)
                {
                minLenght = second.Length;
                smallerPoly = 2;
                }
            else
                {
                minLenght = first.Length;
                smallerPoly = 1;
                }

            for (int i = 0; i < minLenght; i++)
                {
                result[i] = first[i] + second[i];
                }

            for (int i = minLenght; i < result.Length; i++)
                {
                if (smallerPoly == 1)
                    {
                    result[i] = second[i];
                    }
                else
                    {
                    result[i] = first[i];
                    }
                }
            }

        // declaring a printing method
        static void PrintPolynomial(decimal[] polynomial)
            {
            for (int i = polynomial.Length - 1; i >= 0; i--)
                {
                if (polynomial[i] != 0 && i != 0)
                    {
                    if (polynomial[i - 1] >= 0)
                        {
                        Console.Write("{1}x^{0} + ", i, polynomial[i]);
                        }
                    else
                        {
                        Console.Write("{1}x^{0} ", i, polynomial[i]);
                        }
                    }
                else if (i == 0)
                    {
                    Console.WriteLine(polynomial[i]);
                    }
                }
            Console.WriteLine();
            }
        }
    }

