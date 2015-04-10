using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
// Example: http://telerikacademy.com/Courses/Courses/Details/212
/* Result:[protocol] = http 
[server] = telerikacademy.com 
[resource] = /Courses/Courses/Details/212*/

namespace _12.ParseUrl
{
    internal class ParseUrl
    {
        private static void Main()
        {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        int protocolLength = url.IndexOf(":", StringComparison.Ordinal);
        int serverLength = url.IndexOf("/", protocolLength + 3, StringComparison.Ordinal) - protocolLength - 3;
        int resoourceStartIndex = url.IndexOf("/", protocolLength + 3, StringComparison.Ordinal);

        string protocol = url.Substring(0, protocolLength);
        string server = url.Substring(protocolLength + 3, serverLength);
        string resource = url.Substring(resoourceStartIndex);

        Console.WriteLine("The URL adress is:");
        Console.WriteLine(url);
        Console.WriteLine("Result:");
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
