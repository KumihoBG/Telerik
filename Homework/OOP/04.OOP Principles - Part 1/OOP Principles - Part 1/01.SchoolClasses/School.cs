namespace _01.SchoolClasses
    {
    using System.Collections.Generic;
    using System.Text;

    public class School
        {
        private string name;
        private List<Student> students;
        private List<ClassesOfStudents> classes;
        private List<Teacher> teachers;
        private List<Disciplines> disciplines;

        protected School(string name, List<Student> students, List<ClassesOfStudents> classes, List<Teacher> teachers, List<Disciplines> disciplines)
            {
            this.name = name;
            this.Students = students;
            this.Classes = classes;
            this.Teachers = teachers;
            this.Disciplines = disciplines;
            }

        public string Name { get; private set; }

        public List<Student> Students { get; private set; }

        public List<ClassesOfStudents> Classes { get; private set; }

        public List<Teacher> Teachers { get; private set; }

        public List<Disciplines> Disciplines { get; private set; }

        public void AddStudent(Student student)
            {
            students.Add(student);
            }

        public void AddTeacher(Teacher teacher)
            {
            teachers.Add(teacher);
            }

        public void AddDiscipline(Disciplines discipline)
            {
            disciplines.Add(discipline);
            }

        public override string ToString()
            {
            var result = new StringBuilder();
            result.AppendFormat("Name of the school: {0}\n", this.Name);
            result.AppendFormat("Students from this school: {0}\n", this.Students);
            result.AppendFormat("Classes of students: {0}\n", this.Classes);
            result.AppendFormat("Teachers from this school: {0}\n", this.Teachers);
            result.AppendFormat("Disciplines: {0}\n", this.Disciplines);
            return result.ToString();
            }
        }
    }
