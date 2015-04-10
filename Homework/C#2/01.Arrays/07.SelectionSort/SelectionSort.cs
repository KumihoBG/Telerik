using System;
// Write a program to sort an array using the Selection sort algorythm;
public class SortingAlgorythm // creating a new class for our methods
    {
    private static int[] Sort(params int[] someNumbers) // "params" accepts random number of array elements
        {
        for (int i = 0; i < someNumbers.Length - 1; i++) //loop operates over the sorted part of the array
            {
            for (int j = i + 1; j < someNumbers.Length; j++) // loops operates over the unsorted part
                {
                if (someNumbers[i] > someNumbers[j])
                    {
                    //swaping the values of the elements in the array using a temp variable for the min.number
                    int temp = someNumbers[i];
                    someNumbers[i] = someNumbers[j];
                    someNumbers[j] = temp;
                    }
                }
            }
        return someNumbers; // end of the sorting method
        }

    private static void PrintMyArray(params int[] someNumbers) // this is a method for printing the array
        {
        int i;
        for (i = 0; i < someNumbers.Length; i++)    // printing the sorted array with or without a comma
            {
            if (i != someNumbers.Length - 1)
                {
                Console.Write(someNumbers[i] + " ");
                }
            else
                {
                Console.WriteLine(someNumbers[i]);
                }
            }
        }

    static void Main() // main method
        {
        // input from the console:
        Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
        string text = Console.ReadLine();
        char[] space = { ',', ' ' };
        string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

        int[] someNumbers = new int[newStringInput.Length];
        int i;
        for (i = 0; i < newStringInput.Length; i++)
            {
            someNumbers[i] = int.Parse(newStringInput[i]);
            }

        // using our two methods from the above: for array sort and array print
        int[] arr = Sort(someNumbers);
        PrintMyArray(arr);
        }
    }


