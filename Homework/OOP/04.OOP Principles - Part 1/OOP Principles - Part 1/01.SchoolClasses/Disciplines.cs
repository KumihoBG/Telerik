using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
    {
    public class Disciplines
        {
        private List<Disciplines> disciplines;

        public string Name { get; private set; }

        public int NumberOfLectures { get; private set; }

        public int NumberOfExercises { get; private set; }

        public Disciplines(string name, int numberOfLectures, int numberOfExercises)
            {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
            }

        public static void InitializeDisciplines(List<Disciplines> disciplines)
            {
            disciplines.Add(new Disciplines("English language", 3, 6));
            disciplines.Add(new Disciplines("Bulgarian language", 6, 8));
            disciplines.Add(new Disciplines("Mathematics", 4, 6));
            disciplines.Add(new Disciplines("IT", 2, 6));
            }

        public override string ToString()
            {
            var result = new StringBuilder();
            result.AppendFormat("Discipline: {0}\n", this.Name);
            result.AppendFormat("Number of lectures: {0}\n", this.NumberOfLectures);
            result.AppendFormat("Number of exercises: {0}\n", this.NumberOfExercises);
            return result.ToString();
            }
        }
    }
