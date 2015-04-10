/*bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and with draw money.
Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.*/
using System;
using BankAccounts;

namespace _02.BankAccounts
    {
    public class BankAccountsMain
        {
        public static void Main()
            {
            // initializing new bank instance and a random generator
            var bank = new Bank();
            var rnd = new Random();

            // adding new accounts from different types
            bank.AddAccount(new MortgageAccount(new Individual("Aleksander Ivanov"), 11000.0M, 15.4M));
            bank.AddAccount(new DepositAccount(new Company("Primus Ltd."), 23000.0M, 16.2M));
            bank.AddAccount(new LoanAccount(new Company("Idea S.A."), 100000.0M, 2.2M));
            bank.AddAccount(new LoanAccount(new Individual("Penka Arabova"), 7568.0M, 9.7M));

            // printing the accounts
            foreach (var account in bank.GetAccounts())
                {
                var months = rnd.Next(5, 13);
                Console.WriteLine("{0}'s bank account's balance after {1} months: $ {2:F2}", account.Customer.Name, months, account.CalculateInterest(months));
                }
            }
        }
    }