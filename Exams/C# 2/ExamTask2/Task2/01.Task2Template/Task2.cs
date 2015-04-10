using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task2Template
    {
    internal class Task2
        {
        private const int NO_PREVIOUS = -1;

        private static void Main()
            {
            // the input
            int n = int.Parse(Console.ReadLine());

            var newLines = new List<string>();
            for (int i = 0; i < n; i++)
                {
                newLines.Add(Console.ReadLine());
                }

            // the logic
            var averages = new List<double>();
            foreach (var list in newLines)
                {
                var diffs = new List<int>();
                for (int i = 0; i < list.Length - 1; i++)
                    for (int j = i + 1; j < list.Length; j++)
                        diffs.Add(Math.Abs(list[i] - list[j]));
                averages.Add(diffs.Average());
                }

            double[] seq = averages.ToArray();
            for (int i = 1; i < newLines.Count - 1; i++)
                {
                if (seq[i - 1] >= seq[i])
                    {
                    Console.WriteLine("True");
                    }
                else
                    {
                    Console.WriteLine("False");
                    }
                }
            }
        }
    }

