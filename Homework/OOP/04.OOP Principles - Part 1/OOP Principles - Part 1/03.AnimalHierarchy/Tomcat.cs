namespace _03.AnimalHierarchy
    {
    using System;

    class Tomcat : Cat
        {
        public Tomcat(string name, byte age)
            : base(name, age, true) { }

        public override void SaySomething()
            {
            Console.WriteLine("Tomcat says miau, miau, miau!");
            }
        }
    }
