/*
    Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
    Write a program to test this functionality.
*/
namespace _04.PersonClass
    {
    using System;

    public class PersonClass
        {
        public static void Main()
            {
            Person pesho = new Person("Sasho");
            Person gosho = new Person("Kuncho", 34);
            Console.WriteLine();
            Console.WriteLine(new string('*', 28));
            Console.WriteLine("Person with unspecified age:\n{0}", pesho);
            Console.WriteLine();
            Console.WriteLine(new string('*', 26));
            Console.WriteLine("Person with specified age:\n{0}", gosho);
            Console.WriteLine();
            }
        }
    }
