namespace _03.FirstBeforeLast
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class for finding students whose first name is before their last name, alphabetically
    /// </summary>
    public class FirstBeforeLast
        {
        /// <summary>
        /// The main method of the program
        /// </summary>
        public static void Main()
            {
            var students = new List<Student>();
            StudentsInClass(students);

            Console.WriteLine("The list of all students:");
            Console.WriteLine(new string('*', 25));
            foreach (var student in students)
                {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Age);
                }
            Console.WriteLine();

            // Problem 3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically
            // Use LINQ query operators.

            var selectedStudents =
                from student in students
                where String.Compare(student.FirstName, student.LastName, StringComparison.Ordinal) < 0
                select student;
            Console.WriteLine("Problem 3 --> This is the list of students whose first name is before their last name:");
            Console.WriteLine(new string('*', 86));
            foreach (Student student in selectedStudents)
                {
                Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            Console.WriteLine();

            // Problem 4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

            selectedStudents =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;
            Console.WriteLine("Problem 4 --> The list of students with age between 18 and 24:");
            Console.WriteLine(new string('*', 62));
            foreach (Student student in selectedStudents)
                {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Age);
                }
            Console.WriteLine();

            // Problem 5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.

            Console.WriteLine("Problem 5 --> The list of students sorted by first name and then by last name:");
            Console.WriteLine(new string('*', 78));
            selectedStudents = students
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            foreach (var student in selectedStudents)
                {
                Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            Console.WriteLine();

            // Problem 5. Rewrite the same with LINQ.
            selectedStudents =
               from student in students
               orderby student.FirstName, student.LastName
               select student;
            Console.WriteLine("Problem 5 --> List of students sorted by first name then by last name, using LINQ:");
            Console.WriteLine(new string('*', 82));
            foreach (Student student in selectedStudents)
                {
                Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            Console.WriteLine();
            }

        /// <summary>
        /// Initializes students in the class
        /// </summary>
        /// <param name="students">new list of students</param>
        public static void StudentsInClass(List<Student> students)
            {
            students.Add(new Student("Aleksandar", "Nikolov", 18));
            students.Add(new Student("Petya", "Dimitrova", 17));
            students.Add(new Student("Penka", "Georgieva", 24));
            students.Add(new Student("Ekaterina", "Ivanova", 22));
            students.Add(new Student("Ivan", "Petrov", 19));
            students.Add(new Student("Petar", "Ivanov", 18));
            students.Add(new Student("Yuri", "Aleksandrov", 17));
            }
        }
    }
