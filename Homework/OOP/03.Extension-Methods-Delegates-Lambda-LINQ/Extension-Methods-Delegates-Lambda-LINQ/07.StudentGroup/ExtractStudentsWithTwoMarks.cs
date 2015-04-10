namespace _07.StudentGroup
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class for extracting students with mark 2
    /// </summary>
    public static class ExtractStudentsWithTwoMarks
        {
        /// <summary>
        /// A public method to extract students
        /// </summary>
        /// <param name="list">List of students</param>
        public static void ExtractStudents(this IList<Student> list)
            {
            Console.WriteLine("Problem 14 -- > The list of the students that have at least one mark Two(2), using extension method: ");
            Console.WriteLine(new string('*', 100));
            var studentsByMarks =
                from student in list
                where student.Mark.Contains(2)
                select student;

            foreach (var person in studentsByMarks)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }
            }
        }
    }
