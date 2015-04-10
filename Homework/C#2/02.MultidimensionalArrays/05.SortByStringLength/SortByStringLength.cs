using System;

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

namespace SortByStringLength
    {
    class SortByStringLength
        {
        static void Main()
            {
            // the input
            Console.Write("Enter some text on a single line. The words should be separated by space or comma: ");
            string text = Console.ReadLine();
            char[] space = { ',', ' ', '.' };
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            //sorting strings by lenghts
            Array.Sort(newStringInput, (x, y) => x.Length.CompareTo(y.Length));

            //printing the result of the comparison
            foreach (string str in newStringInput) 
                {
                Console.WriteLine(str, StringComparison.CurrentCultureIgnoreCase); //we ignore if the letters
                }                                        // are capital or small - not necessary, just for
            Console.WriteLine();                         // demonstration
            }
        }
    }
