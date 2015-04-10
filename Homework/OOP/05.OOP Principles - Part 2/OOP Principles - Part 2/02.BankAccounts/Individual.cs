namespace _02.BankAccounts
    {
    using System;

    public class Individual : Customer
        {
        private string name;

        public Individual(string name) : base("Katerina Ivanova")
        {
            this.name = name;
        }

        public new string Name
            {
            get
                {
                return this.name;
                }

            set
                {
                if (string.IsNullOrEmpty(value))
                    {
                    throw new Exception("Name cannot be null or empty");
                    }
                }
            }
        }
    }
