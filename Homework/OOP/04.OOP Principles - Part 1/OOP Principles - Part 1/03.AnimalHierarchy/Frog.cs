namespace _03.AnimalHierarchy
    {
    using System;

    public class Frog : Animal
        {
        public Frog(string name, byte age, bool isMale)
            : base(name, age, isMale) { }

        public override void SaySomething()
            {
            Console.WriteLine("Rabbit, rabbit, rabbit...");
            }
        }
    }
