namespace _01.SchoolClasses
    {
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : IPeople
        {
        private List<Teacher> teachers;
        private string discipline;

        public Teacher(string name, string discipline)
            {
            this.Name = name;
            this.discipline = discipline;
            }

        public string Name { get; private set; }

        public static void InitializeTeachers(List<Teacher> teachers)
            {
            teachers.Add(new Teacher("Katya Dimitrova", "Mathematics"));
            teachers.Add(new Teacher("Ivanka Petrova", "Bulgarian"));
            teachers.Add(new Teacher("Vania Trifonova", "English"));
            teachers.Add(new Teacher("Grigor Kirkov", "IT"));
            teachers.Add(new Teacher("Aleksandra Georgieva", "Philosophy"));
            }

        public override string ToString()
            {
            var result = new StringBuilder();
            result.AppendFormat("Name: {0}\n", this.Name);
            return result.ToString();
            }
        }
    }
