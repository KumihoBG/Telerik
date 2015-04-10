// We are given an array of integers and a number S;
// Write a program to find if there exists a subset of the elements of the array that has a sum S;
// {2, 1, 2, 4, 3, 5, 2, 6}, sum = 14 --> output: yes

using System;
using System.Collections.Generic;
using System.Linq;

class SubSetSum
{
    static int[] numbers;
    static int s;
    static bool solution = false;

    private static void PrintSubset(List<int> subset)
    {
        Console.Write("Sum = {0} ->", s);
        for (int i = 0; i < subset.Count; i++)
        {
            Console.Write("{0,3}", subset[i]);
        }
        Console.WriteLine();
    }
    private static int CalculateSum(List<int> subset)
    {
        int sum = 0;
        for (int i = 0; i < subset.Count; i++)
            sum = sum + subset[i];
        return sum;
    }
    static void MakeSubset(int index, List<int> subset)
    {
        int sum = CalculateSum(subset);
        if (sum == s) // if subset = s print subset members
        {
            PrintSubset(subset);
            solution = true;
        }
        if (subset.Count == numbers.Length) // if susbset size = input array size
            return; // nothing to do more, return
        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]); // add I-th element to the susbset list
            Console.WriteLine(string.Join(" ", subset));
            MakeSubset(i + 1, subset); // call MakeSubset recursively
            subset.RemoveAt(subset.Count - 1); // remove last element
        }
    }
    static void Main()
    {
        // input array
        Console.WriteLine("Please enter a sequence of numbers, separated by space or comma: ");
        char[] delimiter = new char[] { ',', ' ' };
        numbers = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        // input S
        Console.Write("Enter subset sum to check for: ");
        s = int.Parse(Console.ReadLine());

        // logic
        List<int> subset = new List<int>();
        MakeSubset(0, subset);
        if (!solution)
            Console.WriteLine("No subset with sum of {0}.", s);
    }
}