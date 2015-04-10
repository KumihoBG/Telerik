namespace _03.AnimalHierarchy
    {
    using System;

    class Kitten : Cat
        {
        public Kitten(string name, byte age)
            : base(name, age, false) { }

        public override void SaySomething()
            {
            Console.WriteLine("Miau, miau, miau!");
            }
        }
    }
