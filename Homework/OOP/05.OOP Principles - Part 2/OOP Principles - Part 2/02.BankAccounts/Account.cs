namespace _02.BankAccounts
    {
    using System;

    public class Account
        {
        private Customer customer;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interest)
            {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
            }

        public Customer Customer
            {
            get
                {
                return this.customer;
                }

            protected set
                {
                if (value == null)
                    {
                    throw new ArgumentNullException("This customer does not exist in the system");
                    }

                this.customer = value;
                }
            }

        public decimal Balance { get; protected set; }

        public decimal InterestRate
            {
            get { return this.interestRate; }
            protected set { this.interestRate = value; }
            }

        public void DepositMoney(decimal amount)
            {
            if (amount <= 0)
                {
                throw new ArgumentException("Deposit amount should be positive!");
                }

            this.Balance += amount;
            }

        public virtual decimal CalculateInterest(int numberOfMonths)
            {
            return numberOfMonths * this.interestRate;
            }
        }
    }
