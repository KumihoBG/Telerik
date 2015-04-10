using System;

/* Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.*/

namespace _06.StringLength
    {
    class StringLenght
        {
        static void Main()
            {
            Console.WriteLine("Enter some text (the max lenght is 20 characters: ");
            string someText = Console.ReadLine();
            char pad = '*';

            int actualLenght = someText.Length;
            if (actualLenght < 20)
                {
                var result = someText.PadRight(20, pad);
                Console.WriteLine(result);
                }
            else
                {
                Console.WriteLine("The current text has more than 20 characters and it won't be filled with the char \"*\"!");
                }
            }
        }
    }
