namespace _07.StudentGroup
    {
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// A class Student
    /// </summary>
    public class Student
        {
        private readonly List<Student> students;
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string tel;
        private string email;
        private string departmentName;
        private int groupNumber;
        private List<double> marks;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <param name="facultyNumber">faculty number</param>
        /// <param name="tel">telephone number</param>
        /// <param name="email">e-mail address</param>
        /// <param name="marks">marks and grading</param>
        /// <param name="groupNumber">the number of the group</param>
        /// <param name="departmentName">the name of the department</param>
        public Student(string firstName, string lastName, string facultyNumber, string tel, string email, List<double> marks, int groupNumber, string departmentName)
            {
            this.firstName = firstName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.tel = tel;
            this.email = email;
            this.groupNumber = groupNumber;
            this.marks = new List<double>(marks);
            this.departmentName = departmentName;
            }

        /// <summary>
        /// Gets the property for the first name of the student
        /// </summary>
        public string FirstName
            {
            get { return this.firstName; }
            }

        /// <summary>
        /// Gets the property for the last name of the student
        /// </summary>
        public string LastName
            {
            get { return this.lastName; }
            }

        /// <summary>
        /// Gets the property for the faculty number of the student
        /// </summary>
        public string FacultyNumber
            {
            get { return this.facultyNumber; }
            }

        /// <summary>
        /// Gets the property for the telephone of the student
        /// </summary>
        public string Tel
            {
            get { return this.tel; }
            }

        /// <summary>
        /// Gets the property for the e-mail of the student
        /// </summary>
        public string Email
            {
            get { return this.email; }
            }

        /// <summary>
        /// Gets the property for the mark of the student
        /// </summary>
        public List<double> Mark
            {
            get { return this.marks; }
            }

        /// <summary>
        /// Gets the property for the group name of the student
        /// </summary>
        public int GroupNumber
            {
            get { return this.groupNumber; }
            }

        /// <summary>
        /// Gets the property for the department name of the student
        /// </summary>
        public string DepartmentName
            {
            get { return this.departmentName; }
            }

        public IEnumerable<Student> Students
            {
            get { return this.students; }
            }

        /// <summary>
        /// Initializes a group of students
        /// </summary>
        /// <param name="students">different students inside the group</param>
        public static void InitilaizeStudents(List<Student> students)
            {
            students.Add(new Student("Aleksandar", "Nikolov", "802606", "02456789", "nikolov@abv.bg", new List<double> { 6, 5, 6 }, 1, "Mathematics"));
            students.Add(new Student("Petya", "Dimitrova", "772422", "0989675432", "dimitrova@abv.bg", new List<double> { 4, 2, 5 }, 2, "English"));
            students.Add(new Student("Penka", "Georgieva", "802433", "02675435", "georgieva@gmail.com", new List<double> { 5, 6, 6 }, 1, "Bulgarian"));
            students.Add(new Student("Ekaterina", "Ivanova", "567806", "0989768931", "ivanova@yahoo.com", new List<double> { 2, 3, 2 }, 2, "Mathematics"));
            students.Add(new Student("Ivan", "Petrov", "806783", "0888698034", "petrov@abv.bg", new List<double> { 6, 6, 6 }, 2, "IT"));
            students.Add(new Student("Petar", "Ivanov", "6034106", "02678654", "ivanov@gmail.com", new List<double> { 5, 5, 6 }, 1, "Law"));
            students.Add(new Student("Yuri", "Aleksandrov", "542322", "0989789654", "aleksandrov@abv.bg", new List<double> { 5, 4, 3 }, 1, "Mathematics"));
            }

        /// <summary>
        /// Prints the students inside the selected group
        /// </summary>
        /// <param name="output">different properties of the student</param>
        public void PrintStudents(TextWriter output)
            {
            output.WriteLine("First name: {0}", this.FirstName);
            output.WriteLine("Last name: {0}", this.LastName);
            output.WriteLine("Faculty Number: {0}", this.FacultyNumber);
            output.WriteLine("Tel: {0}", this.Tel);
            output.WriteLine("Email: {0}", this.Email);
            output.WriteLine("Marks: {0}", string.Join(", ", this.Mark));
            output.WriteLine("Group number: {0}", this.GroupNumber);
            output.WriteLine("Department name: {0}", this.DepartmentName);
            }
        }
    }