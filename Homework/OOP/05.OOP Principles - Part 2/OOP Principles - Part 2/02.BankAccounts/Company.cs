namespace _02.BankAccounts
    {
    using System;

    public class Company : Customer
        {
        private string name;

        public Company(string name) : base("Telerik")
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
