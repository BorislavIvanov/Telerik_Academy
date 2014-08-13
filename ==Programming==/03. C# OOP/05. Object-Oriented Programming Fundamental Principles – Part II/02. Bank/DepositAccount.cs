using System;
using System.Text;

class DepositAccount : BankAccount, IDeposit, IWithdraw, IInterestCalculation
{
    private int depositPeriod;

    // Property
    public int DepositPeriod
    {
        get { return this.depositPeriod; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException("The Deposit Period must be min 1 month!!!");
            }
            else
            {
                this.depositPeriod = value;
            }
        }
    }

    // Constructor
    public DepositAccount(Customer customer, decimal balance, decimal interestRate, int depositPeriod) : base(customer, balance, interestRate)
    {
        this.DepositPeriod = depositPeriod;
    }

    // Methods
    public void Deposit(decimal value)
    {
        this.Balance += value;
    }
    public void Withdraw(decimal value)
    {
        if (this.Balance < value)
        {
            throw new Exception("You dont have enought money in the account!!!");
        }
        else
        {
            this.Balance -= value;
        }
    }
    public decimal CalculateInterestRate()
    {
        if (this.Balance < 1000)
        {
            return 0;
        }
        else
        {
            return (this.InterestRate * this.Balance) * DepositPeriod;
        }
    }
    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendLine(new string('-', 10));
        print.AppendLine("Deposit Account - Owner: " + this.Customer.CustomerName);
        print.AppendLine("Balance - " + this.Balance + ", InterestRate - " + this.InterestRate + ";");
        print.AppendLine("Deposit Period - " + this.DepositPeriod + ", Interest amount for the period - " + CalculateInterestRate() + ";");
        print.AppendLine(new string('-', 10));

        return print.ToString();
    }
}