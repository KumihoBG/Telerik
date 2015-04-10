namespace _03.FirstBeforeLast
    {
    using System.Collections.Generic;

    /// <summary>
    /// The student class
    /// </summary>
    public class Student
        {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">first name of the student</param>
        /// <param name="lastName">last name of the student</param>
        /// <param name="age">age of the student</param>
        public Student(string firstName, string lastName, int age)
            {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            }

        /// <summary>
        /// Gets or sets the properties of the class student
        /// </summary>
        public static int NewStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        }
    }
