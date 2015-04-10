namespace _03.AnimalHierarchy
    {
    using System;

    public class Cat : Animal
        {
        public Cat(string name, byte age, bool isMale)
            : base(name, age, isMale) { }

        public override void SaySomething()
            {
            Console.WriteLine("Miao, miao, miao...");
            }
        }
    }
