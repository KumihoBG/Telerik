using System;
using System.Linq;

namespace SayHello
    {
    public class SayHello
        {
        public static void Main()
            {
            // Write a method that asks the user for his name and prints “Hello, <name>”
            // Write a program to test this method;
            // Please, look the next project - UnitTestSayHello;

            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();

            // calling the methods from below
            if (myName.Length != 0)
                {
                AnotherTest(myName);
                }
            else
                {
                Console.WriteLine(PrintSomeName(myName));
                }
            }

        //declaring the method
        public static string PrintSomeName(string myName)
            {
            return string.Format("Hello, {0}", myName);
            }

        // another method to check if the input is letter
        public static void AnotherTest(string str)
            {
            bool isCorrect = str.All(Char.IsLetter);
            if (isCorrect)
                {
                Console.WriteLine("Hello, {0}!", str);
                }
            else
                {
                Console.WriteLine("The input does not meet the necessary requirements!");
                }
            }
        }
    }
