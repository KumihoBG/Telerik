using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
// Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages.
// System.IO.File.ReadAllText(…) opens a text file, reads all lines of the file, and then closes the file.

namespace _03.ReadFileContents
    {
    class ReadFileContents
        {
        static void Main()
            {
            // the input
            Console.Write("Enter full file path (e.g. C:\\WINDOWS\\win.ini): ");
            string filePath = Console.ReadLine();

            // calling method from below
            ReadFile(filePath);
            }

        // declaring a method to read the file and to handle the exceptions
        static void ReadFile(string filePath)
            {
            try
                {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("Printing the content: ");
                Console.WriteLine(fileContent);
                }
            catch (ArgumentException ex)
                {
                Console.WriteLine(ex.Message);
                }
            catch (PathTooLongException ex)
                {
                Console.WriteLine(ex.Message);
                }
            catch (DirectoryNotFoundException ex)
                {
                Console.WriteLine(ex.Message);
                }
            catch (IOException ex)
                {
                Console.WriteLine(ex.Message);
                }
            catch (UnauthorizedAccessException ex)
                {
                Console.WriteLine(ex.Message);
                }
            catch (NotSupportedException ex)
                {
                Console.WriteLine(ex.Message);
                }
            }
        }
    }
