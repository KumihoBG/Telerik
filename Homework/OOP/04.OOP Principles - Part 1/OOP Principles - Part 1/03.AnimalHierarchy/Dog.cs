namespace _03.AnimalHierarchy
    {
    using System;

    public class Dog : Animal
        {
        public Dog(string name, byte age, bool isMale)
            : base(name, age, isMale) { }

        public override void SaySomething()
            {
            Console.WriteLine("Baff, baff, baff!");
            }
        }
    }
