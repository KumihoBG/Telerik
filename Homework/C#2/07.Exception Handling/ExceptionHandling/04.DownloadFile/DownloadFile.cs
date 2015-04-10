using System;
using System.Net;

// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
// Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

namespace _04.DownloadFile
    {
    class DownloadFile
        {
        static void Main()
            {
            using (WebClient downloadClient = new WebClient())
                {
                try
                    {
                    // The simply way how to download file is to use WebClient class and its method DownloadFile. 
                    // This method has two parameters, first is the url of the file you want to download and the second parameter is path to local disk to which you want to save the file.
                    Console.WriteLine("Downloading file. Please, wait...");
                    downloadClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
                    Console.WriteLine("Download completed!");
                    }
                catch (ArgumentException ex)
                    {
                    Console.WriteLine(ex.Message);
                    }
                catch (WebException ex)
                    {
                    Console.WriteLine(ex.Message);
                    }
                catch (NotSupportedException ex)
                    {
                    Console.WriteLine(ex.Message);
                    }
                finally
                    {
                    //by Dispose()ing in a finally block allows you to control when resources are released
                    downloadClient.Dispose(); 
                    }
                }
            }
        }
    }
