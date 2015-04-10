namespace _07.StudentGroup
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class to group students by Group name
    /// </summary>
    public static class GroupedByGroupNameExtensions
        {
        /// <summary>
        /// A public method to extract students by group name
        /// </summary>
        /// <param name="list">List of students</param>
        public static void ExtractStudentsByGroup(this IList<Student> list)
            {
            Console.WriteLine("Problem 19 -- > The list of the students by their Group name, using extension method: ");
            Console.WriteLine(new string('*', 85));
            var studentsByGroupName = list
                .OrderBy(s => s.GroupNumber);

            foreach (var person in studentsByGroupName)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }
            }
        }
    }
