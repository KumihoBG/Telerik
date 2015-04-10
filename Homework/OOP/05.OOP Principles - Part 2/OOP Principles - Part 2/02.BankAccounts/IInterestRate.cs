namespace _02.BankAccounts
    {
    public interface IInterestRate
        {
        int NumberOfMonths { get; }

        double InterestRate { get; }
        }
    }
