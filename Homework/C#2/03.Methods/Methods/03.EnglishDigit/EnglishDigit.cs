using System;

// Write a method that returns the last digit of given integer as an English word;
// Ex. input = 512; output = two
namespace EnglishDigit
    {
    class EnglishDigit
        {
        static void Main()
            {
            Console.Write("Please, enter some digit: ");
            int digit = int.Parse(Console.ReadLine());
            int lastDigit;
            GetValue(digit, out lastDigit);
            }

        private static void GetValue(int digit, out int lastDigit)
            {
            lastDigit = Math.Abs(digit % 10);
            switch (lastDigit)
                {
                case 0:
                    Console.WriteLine("The last digit is: Zero");
                    break;
                case 1:
                    Console.WriteLine("The last digit is: One");
                    break;
                case 2:
                    Console.WriteLine("The last digit is: Two");
                    break;
                case 3:
                    Console.WriteLine("The last digit is: Three");
                    break;
                case 4:
                    Console.WriteLine("The last digit is: Four");
                    break;
                case 5:
                    Console.WriteLine("The last digit is: Five");
                    break;
                case 6:
                    Console.WriteLine("The last digit is: Six");
                    break;
                case 7:
                    Console.WriteLine("The last digit is: Seven");
                    break;
                case 8:
                    Console.WriteLine("The last digit is: Eight");
                    break;
                case 9:
                    Console.WriteLine("The last digit is: Nine");
                    break;
                }
            }
        }
    }
