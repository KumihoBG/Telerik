namespace _02.StudentsAndWorkers
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsAndWorkers
        {
        static void Main()
            {
            var students = new List<Student>
			               {
				               new Student("Ivan", "Vasilev", 4.56),
							   new Student("Petka", "Ivanova", 2.76),
							   new Student("Ivelina", "Georgieva", 5.0),
							   new Student("Petya", "Paskaleva", 5.3),
							   new Student("Katya", "Dimitrova", 3.60),
							   new Student("Maria", "Trifonova", 3.46),
							   new Student("Georgi", "Iliev", 6.00),
			               };

            var sortdedStudents = students.OrderBy(st => st.Grade);
            Console.WriteLine("The list of the sorted students");
            Console.WriteLine(new string ('*', 31));
            foreach (var student in sortdedStudents)
                {
                Console.Write(student);
                }
            Console.WriteLine();
            var workers = new List<Worker>
			               {
				               new Worker("Pesho", "Vasilev", 150.00, 4),
							   new Worker("Gosho", "Petrakiev", 250.00, 4),
							   new Worker("Dragan", "Tzvetkov", 350.00, 8),
							   new Worker("Emil", "Kodjabashev", 450.00, 8),
							   new Worker("Vasil", "Dragoev", 550.00, 8),
							   new Worker("Petko", "Atanasov", 650.00, 8),
			               };

            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine("The list of the sorted workers");
            Console.WriteLine(new string('*', 30));
            foreach (var worker in sortedWorkers)
                {
                Console.WriteLine(worker);
                }

            var mergedList = new List<Human>();
            mergedList.AddRange(sortdedStudents);
            mergedList.AddRange(sortedWorkers);

            var sortedList = mergedList.OrderBy(x => x.FirstName)
                                       .ThenBy(x => x.LastName);

            Console.WriteLine("The list of the merged and sorted student and workers:");
            Console.WriteLine(new string('*', 54));
            foreach (var human in sortedList)
                {
                Console.WriteLine(human);
                }
            }
        }
    }

