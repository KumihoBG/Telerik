/*Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
  Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=*/
namespace _01_03.StudentClass
    {
    using System;

    public class StudentClass
        {
        public static void Main()
            {
            // Problem 1 - Initializing an instance of the Student class
            var student = new Student(
                "Aleksander", 
                "Ivanov", 
                "Tasev", 
                "028763455", 
                "Sofia, Center", 
                "0888 607894", 
                "aleksandar.tasev@gmail.com", 
                "Legal Department", 
                Speciality.Law, 
                University.Harvard,
                Faculty.Law);

            // Printing the original student's details:
            Console.WriteLine("This is the original instance of the object from the Student's class: ");
            Console.WriteLine(new string('*', 69));
            Console.WriteLine(student.ToString());

            // Problem 2 - cloning the student's instance using deep cloning
            Console.WriteLine("This is the cloned instance of the object from the Student's class: ");
            Console.WriteLine(new string('*', 67));
            object otherStudent = student.Clone();
            Console.WriteLine(otherStudent);

            // Problem 3 - comapring the original and the clone
            Console.WriteLine("Comparing student Aleksander with the clone:");
            Console.WriteLine(new string('*', 44));
            Console.WriteLine("Overriding the == operator: {0}", student == (Student)otherStudent);
            Console.WriteLine("Overriding the != operator: {0}", student != (Student)otherStudent);
            Console.WriteLine("Using .Equals() method: {0}", student.Equals(otherStudent));
            Console.WriteLine("Using .CompareTo() method: {0}\n", student.CompareTo(otherStudent));
            }
        }
    }
