using System;
//  Write a program that can solve these tasks:
//  Reverses the digits of a number
//  Calculates the average of a sequence of integers
//  Solves a linear equation a * x + b = 0
//  Create appropriate methods.
//  Provide a simple text-based menu for the user to choose which task to solve.
//  Validate the input data:
//      The decimal number should be non-negative
//      The sequence should not be empty
//      'a' should not be equal to 0

namespace _13.SolveTasks
    {
    class SolveTasks
        {
        static void Main()
            {
            // the input
            Console.WriteLine("If you want to reverse a number:                         press 1");
            Console.WriteLine("If you want to calculata the avarege of sequence:        press 2");
            Console.WriteLine("If you want to solve a linear equation a * x + b = 0:    press 3");
            Console.Write("Choose option: ");
            int option = int.Parse(Console.ReadLine());
            while (option < 1 || option > 3)
                {
                Console.Write("Wrong option! Input again ");
                option = int.Parse(Console.ReadLine());
                }

            if (option == 1)
                {
                Option1();
                }
            else if (option == 2)
                {
                Option2();
                }
            else
                {
                Option3();
                }
            }

        // declaring the linear equation solving method
        private static void Option3()
            {
            Console.Write("Input number a: ");
            int a = int.Parse(Console.ReadLine());
            while (a == 0)
                {
                Console.Write("Wrong! Input again!");
                a = int.Parse(Console.ReadLine());
                }
            Console.Write("Input number b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("x= {0}", (-b / (double)a));
            }

        // declaring the average sequence method
        private static void Option2()
            {
            Console.Write("How many numbers you want to sum? Enter your choice: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 1)
                {
                Console.Write("Wrong! Input again!");
                n = int.Parse(Console.ReadLine());
                }
            int[] array = new int[n];
            double sum = 0;
            for (int i = 0; i < n; i++)
                {
                Console.Write("Input number {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
                }
            //Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Avg is: " + sum / n);
            }

        // declaring the reverse method
        private static void Option1()
            {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The initial number is: " + num);
            Console.WriteLine("The reversed number is " + Reverse(num));
            }
        //separate method for counting the digits
        static int CountDigits(int num)
            {
            int count = 0;
            while (num != 0)
                {
                num /= 10;
                count++;
                }
            return count;
            }

        // separated method for reversing the number
        static int Reverse(int num)
            {
            int cnt = CountDigits(num);
            int tmpNum = 0;
            for (int i = cnt - 1; i >= 0; i--)
                {
                tmpNum += (num % 10) * (int)Math.Pow(10, i);
                num /= 10;
                }
            return tmpNum;
            }

        }
    }

