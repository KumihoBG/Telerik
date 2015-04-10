// Problem 9. Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.Create a List<Student> with sample students. 
// IMPORTANT: Please, resize your console size in case the results are not printed correctly. Ex.500 x 500
namespace _07.StudentGroup
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class for the group of students
    /// </summary>
    public class StudentGroupMain
        {
        /// <summary>
        /// The main method
        /// </summary>
        public static void Main()
            {
            List<Student> groupOfStudents = new List<Student>();
            Student.InitilaizeStudents(groupOfStudents);

            // Problem 9 - Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
            var groupTwo = groupOfStudents
                .Where(s => s.GroupNumber == 2)
                .OrderBy(s => s.FirstName);
            Console.WriteLine("Problem 9 -- > The list of the students in group No 2, sorted by their first names: ");
            Console.WriteLine(new string('*', 83));

            foreach (var person in groupTwo)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 10 - Implement the previous using the same query expressed with extension method:
            groupOfStudents.GroupStudents();

            // Problem 11 - Extract all students that have email in abv.bg.
            // Use string methods and LINQ. 
            Console.WriteLine("Problem 11 -- > The list of the students that have email in abv.bg: ");
            Console.WriteLine(new string('*', 67));

            var selectedStudents =
                from student in groupOfStudents
                where student.Email.Substring(student.Email.IndexOf("@", StringComparison.Ordinal) + 1) == "abv.bg"
                select student;

            foreach (var person in selectedStudents)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 12 - Extract all students with phones in Sofia. Use LINQ
            Console.WriteLine("Problem 12 -- > The list of the students that have phones in Sofia: ");
            Console.WriteLine(new string('*', 67));

            var studentsByPhone =
                from student in groupOfStudents
                where student.Tel.StartsWith("02")
                select student;

            foreach (var person in studentsByPhone)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 13 - Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
            Console.WriteLine("Problem 13 -- > The list of the students that have at least one mark Excellent(6): ");
            Console.WriteLine(new string('*', 82));
            var studentsByMarks =
                from student in groupOfStudents
                where student.Mark.Contains(6)
                select student;

            foreach (var person in studentsByMarks)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 14 - Write down a similar program that extracts the students with exactly two marks "2". Use extension method.
            groupOfStudents.ExtractStudents();

            // Problem 15 - Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Console.WriteLine("Problem 15 -- > The list with students enrolled in 2006 and their marks: ");
            Console.WriteLine(new string('*', 72));
            var studentsByYear =
                from student in groupOfStudents
                where student.FacultyNumber.EndsWith("06")
                select student;

            foreach (var person in studentsByYear)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 16 - Extract all students from "Mathematics" department.
            Console.WriteLine("Problem 16* -- > The list of the students from Mathematics department: ");
            Console.WriteLine(new string('*', 70));

            Group group1 = new Group(1, "Mathematics");
            Group group2 = new Group(2, "IT");
            Group group3 = new Group(3, "English");
            Group group4 = new Group(3, "Bulgarian");
            Group group5 = new Group(3, "Law");

            List<Group> groups = new List<Group> { group1, group2, group3, group4, group5 };

            var studentsFromMathDepartment =
                from someGroup in groups
                where someGroup.GroupNumber == 1
                join student in groupOfStudents on someGroup.GroupNumber equals student.GroupNumber
                select new
                {
                    Name = student.FirstName + " " + student.LastName,
                    Department = someGroup.DepartmentName
                };

            foreach (var person in studentsFromMathDepartment)
                {
                Console.WriteLine(person);
                Console.WriteLine();
                }

            // Problem 18 - Create a program that extracts all students grouped by GroupNumber and then prints them to the console. Use LINQ.
            Console.WriteLine("Problem 18 -- > The list with students grouped by Group number: ");
            Console.WriteLine(new string('*', 63));
            var groupedByGroupNumber = groupOfStudents
                .OrderBy(s => s.GroupNumber);

            foreach (var person in groupedByGroupNumber)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 19 - Rewrite the previous using extension methods.
            groupOfStudents.ExtractStudentsByGroup();

            // printing the whole list of students in case the user chooses so:
            Console.WriteLine("Would you like to see the whole list of students? Y/N?");

            while (true)
                {
                string overwrite = Console.ReadLine();
                if (overwrite.ToUpper().Equals("Y"))
                    {
                    Console.WriteLine();
                    Console.WriteLine("The full list of the students: ");
                    Console.WriteLine(new string('*', 30));
                    foreach (var person in groupOfStudents)
                        {
                        person.PrintStudents(Console.Out);
                        Console.WriteLine();
                        }

                    break;
                    }
                else if (overwrite.ToUpper().Equals("N"))
                    {
                    Console.WriteLine("Thank you for your choice. Good bye!");
                    break;
                    }
                else
                    {
                    Console.WriteLine("This is not a valid choice");
                    overwrite = Console.ReadLine();
                    }
                }
            }
        }
    }