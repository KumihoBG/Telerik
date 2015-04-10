namespace _01.SchoolClasses
    {
    using System;
    using System.Collections.Generic;

    class SchoolClassesMain
        {
        static void Main()
            {
            // testing classes
            var students = new List<Student>();
            var school = new List<School>();
            var teachers = new List<Teacher>();
            var disciplines = new List<Disciplines>();

            // testing Student class
            Student.InitilaizeStudents(students);
            Console.WriteLine("The list of the students in school: ");
            Console.WriteLine(new string('*', 35));
            foreach (var student in students)
                {
                Console.Write(student);
                }
            Console.WriteLine();

            // testing Teacher class
            Teacher.InitializeTeachers(teachers);
            Console.WriteLine("The list of the teachers in school: ");
            Console.WriteLine(new string ('*', 35));
            foreach (var teacher in teachers)
                {
                Console.Write(teacher);
                }
            Console.WriteLine();

            // testing Disciplines class
            Disciplines.InitializeDisciplines(disciplines);
            Console.WriteLine("The disciplines provided by the school: ");
            Console.WriteLine(new string('*', 39));
            foreach (var discipline in disciplines)
                {
                Console.Write(discipline);
                }
            Console.WriteLine();
            }
        }
    }
