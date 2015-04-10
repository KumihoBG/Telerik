namespace _01_03.StudentClass
    {
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
        {
        // Problem 1 - Class Student
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private string course;
        private Speciality speciality;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress, string mobilePhone, string email, string course, Speciality university, University speciality, Faculty faculty)
            {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.permanentAddress = permanentAddress;
            this.mobilePhone = mobilePhone;
            this.email = email;
            this.course = course;
            this.university = (University)university;
            this.speciality = (Speciality)speciality;
            this.faculty = faculty;
            }

        public string FirstName
            {
            get
            {
                return this.firstName;
            }

            private set
                {
                if (string.IsNullOrEmpty(value))
                    {
                    throw new ArgumentException("First name cannot be null or empty");
                    }

                this.firstName = value;
                }
            }

        public string MiddleName
            {
            get
            {
                return this.middleName;
            }

            private set
                {
                if (string.IsNullOrEmpty(value))
                    {
                    throw new ArgumentException("Middle name cannot be null or empty");
                    }

                this.middleName = value;
                }
            }

        public string LastName
            {
            get
            {
                return this.lastName;
            }

            private set
                {
                if (string.IsNullOrEmpty(value))
                    {
                    throw new ArgumentException("Last name cannot be null or empty");
                    }

                this.lastName = value;
                }
            }

        public string SSN
            {
            get
            {
                return this.ssn;
            }

            private set
                {
                if (string.IsNullOrEmpty(value))
                    {
                    throw new ArgumentException("SSN cannot be null or empty");
                    }

                this.ssn = value;
                }
            }

        public string Address
            {
            get
            {
                return this.permanentAddress;
            }

            private set
                {
                if (string.IsNullOrEmpty(value))
                    {
                    throw new ArgumentException("Address input cannot be null or empty");
                    }

                this.permanentAddress = value;
                }
            }

        public string MobilePhone
            {
            get
            {
                return this.mobilePhone;
            }

            private set
                {
                if (string.IsNullOrEmpty(value))
                    {
                    throw new ArgumentException("Mobile phone cannot be null or empty");
                    }

                this.mobilePhone = value;
                }
            }

        public string Email
            {
            get
            {
                return this.email;
            }

            private set
                {
                if (string.IsNullOrEmpty(value))
                    {
                    throw new ArgumentException("Email cannot be null or empty");
                    }

                this.Email = value;
                }
            }

        public string Course
            {
            get
            {
                return this.course;
            }

            private set
                {
                if (string.IsNullOrEmpty(value))
                    {
                    throw new ArgumentException("Course cannot be null or empty");
                    }

                this.course = value;
                }
            }

        public Speciality Speciality { get; private set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        // overriding the == and != operators
        public static bool operator ==(Student student1, Student student2)
            {
            return Student.Equals(student1, student2);
            }

        public static bool operator !=(Student student1, Student student2)
            {
            return !Student.Equals(student1, student2);
            }

        // overriding the Equals method
        public override bool Equals(object obj)
            {
            var student = obj as Student;
            if (student == null)
                {
                return false;
                }

            if (!object.Equals(this.ssn, student.ssn))
                {
                return false;
                }

            return true;
            }

        public int CompareTo(Student other)
            {
            string student = this.FirstName + this.MiddleName + this.LastName + this.SSN;
            string otherStudent = other.FirstName + other.MiddleName + other.LastName + other.SSN;

            return string.Compare(student, otherStudent, StringComparison.Ordinal);
            }

        // overriding ToString method
        public override string ToString()
            {
            var sb = new StringBuilder();

            sb.AppendFormat("Name: {0} {1} {2}\n", this.FirstName, this.MiddleName, this.LastName);
            sb.AppendLine("SSN: " + this.SSN);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("Mobile Phone: " + this.MobilePhone);
            sb.AppendLine("Email: " + this.Email);
            sb.AppendLine("Course: " + this.Course);
            sb.AppendLine("Speciality: " + this.Speciality);
            sb.AppendLine("University: " + this.University);
            sb.AppendLine("Faculty: " + this.Faculty);

            return sb.ToString();
            }

        // overriding the GetHashCode method
        public override int GetHashCode()
            {
            return this.SSN.GetHashCode() ^ this.MobilePhone.GetHashCode();
            }

        // Problem 2 - Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student
        public object Clone()
            {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.Email, this.Course, this.Speciality, this.University, this.Faculty);
            }

        // Problem 3 - Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
        public int CompareTo(object obj)
            {
            var otherStudent = obj as Student;

            string fullName = this.FirstName + this.MiddleName + this.LastName;

            string otherFullName = otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName;

            if (fullName.CompareTo(otherFullName) < 0)
                {
                return -1;
                }

            if (fullName.CompareTo(otherFullName) > 0)
                {
                return 1;
                }

            if (fullName.CompareTo(otherFullName) == 0)
                {
                if (this.InitializeNumber() < otherStudent.InitializeNumber())
                    {
                    return -1;
                    }

                if (this.InitializeNumber() > otherStudent.InitializeNumber())
                    {
                    return 1;
                    }

                if (this.InitializeNumber() == otherStudent.InitializeNumber())
                    {
                    return 0;
                    }
                }

            return 0;
            }

        private int InitializeNumber()
            {
            var ssnNumber = new StringBuilder();
            foreach (var symbol in this.SSN)
                {
                if (char.IsDigit(symbol))
                    {
                    ssnNumber.Append(symbol);
                    }
                }

            return int.Parse(ssnNumber.ToString());
            }
        }
    }