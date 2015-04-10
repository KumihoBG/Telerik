using System.Collections.Generic;
using System.Text;

namespace _01.SchoolClasses
    {
    public class Student : IPeople
        {
        public int ClassNumber { get; private set; }

        public List<Student> students;

        public Student(string name, int uniqueClassNumber)
            {
            this.Name = name;
            this.ClassNumber = uniqueClassNumber;
            }

        public string Name { get; private set; }

        public IEnumerable<Student> Students
            {
            get
                {
                return this.students;
                }
            }

        public static void InitilaizeStudents(List<Student> students)
            {
            students.Add(new Student("Aleksandar Nikolov", 1));
            students.Add(new Student("Petya Dimitrova", 22));
            students.Add(new Student("Penka Georgieva", 23));
            students.Add(new Student("Ekaterina Ivanova", 7));
            students.Add(new Student("Ivan Petrov", 5));
            }

        public override string ToString()
            {
            var result = new StringBuilder();
            result.AppendFormat("Name: {0}\n", this.Name);
            result.AppendFormat("Unique class number: {0}\n", this.ClassNumber);
            return result.ToString();
            }
        }
    }
