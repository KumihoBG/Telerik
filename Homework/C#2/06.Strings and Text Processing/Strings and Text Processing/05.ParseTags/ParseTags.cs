using System;
using System.Text.RegularExpressions;

/* You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else*/

/* methods:
            Replace(text, pattern, replacement) – замества всички срещания за даден регулярен израз в даден текст със заместващ текст, който може да съдържа части от намерените съвпадения (групи в рег. израз)
             .*? – метасимвол за количество, нула или повече срещания, но най-малкият възможен брой;
             Групите в регулярните изрази дават възможност за извличане и обработка на отделни части от изразите*/

namespace _05.ParseTags
    {
    class ParseTags
        {
        static void Main()
            {
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();
            string pattern = "<upcase>(.*?)</upcase>"; //creating a pattern for replace
            // match and print using regular expressions
            Console.WriteLine(Regex.Replace(text, pattern, word => word.Groups[1].Value.ToUpper()));
             }
        }
    }
            
