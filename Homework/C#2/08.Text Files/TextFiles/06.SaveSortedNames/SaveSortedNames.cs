using System;
using System.Collections.Generic;
using System.IO;

/*  Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
    Example:
    input.txt 	output.txt
    Ivan        George
    Peter       Ivan
    Maria       Maria
    George 	    Peter
*/
namespace _06.SaveSortedNames
    {
    class SaveSortedNames
        {
        static void Main()
            {
            List<string> names = new List<string>();
            using (StreamReader unsorted = new StreamReader("List.txt"))
                {

                for (string current = unsorted.ReadLine(); current != null; current = unsorted.ReadLine())
                    {
                    names.Add(current);
                    }
                names.Sort(); //using Sorting method

                using (StreamWriter sorted = new StreamWriter("SortedList.txt"))
                    {
                    foreach (string name in names)
                        {
                        sorted.WriteLine(name); // collecting the sorted list of names
                        }
                    }
                }
            // printing the result
            Console.WriteLine("This is the sorted list of names: {0}", string.Join(" ", names));
            }
        }
    }

