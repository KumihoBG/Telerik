namespace _01.SchoolClasses
    {
    using System.Collections.Generic;
    using System.Text;

    public class ClassesOfStudents
        {
        private List<ClassesOfStudents> classes;

        public List<Student> Students { get; private set; }

        public List<Teacher> Teachers { get; private set; }

        public string TextIdentifier { get; private set; }

        public ClassesOfStudents(List<Student> students, List<Teacher> teachers, string textIdentifier)
            {
            this.Students = students;
            this.Teachers = teachers;
            this.TextIdentifier = textIdentifier;
            }

        public override string ToString()
            {
            var result = new StringBuilder();
            result.AppendFormat("Class unique text identifier: {0}\n", this.TextIdentifier);
            result.AppendFormat("The number of students inside the class is: {0}\n", Students.Count);
            result.AppendFormat("The number of teachers teaching the class: {0}\n", Teachers.Count);
            return result.ToString();
            }
        }
    }
