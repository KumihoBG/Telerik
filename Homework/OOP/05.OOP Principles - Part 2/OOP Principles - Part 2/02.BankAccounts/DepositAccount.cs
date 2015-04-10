namespace BankAccounts
    {
    using System;
    using _02.BankAccounts;

    public class DepositAccount : Account
        {
        public const decimal MinimumAmountForInterest = 1000;
        private decimal balance;

        public DepositAccount(Customer initialCustomer, decimal initialBalance, decimal initialInterestRate)
            : base(initialCustomer, initialBalance, initialInterestRate)
            {
            }

        public override decimal CalculateInterest(int numberOfMonths)
            {
            if (this.balance >= MinimumAmountForInterest)
                {
                return numberOfMonths * ((this.InterestRate / 100.0M) * this.Balance);
                }
            else
                {
                return 0.0M;
                }
            }

        public void WithdrawMoney(decimal amount)
            {
            if (amount <= 0)
                {
                throw new ArgumentException("The amount cannot be negative!");
                }

            if (amount > this.balance)
            {
                this.balance -= amount;
                throw new ArgumentException("Not enough balance!");
                }
            }
        }
    }