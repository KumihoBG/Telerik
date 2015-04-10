namespace _07.StudentGroup
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An extension class for grouping the students by group and by first name
    /// </summary>
    public static class StudentGroupsExtensions
        {
        /// <summary>
        /// A static extension method
        /// </summary>
        /// <param name="list">List of students</param>
        public static void GroupStudents(this IList<Student> list)
            {
            Console.WriteLine("Problem 10 -- > Sorting students in group 2 by first names, using extension method: ");
            Console.WriteLine(new string('*', 83));
            var newGroup = list
                .Where(s => s.GroupNumber == 2)
                .OrderBy(s => s.FirstName);
            foreach (var student in newGroup)
                {
                student.PrintStudents(Console.Out);
                Console.WriteLine();
                }
            }
        }
    }
