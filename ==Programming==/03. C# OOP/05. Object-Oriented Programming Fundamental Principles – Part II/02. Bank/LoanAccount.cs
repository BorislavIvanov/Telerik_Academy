using System;
using System.Text;

class LoanAccount : BankAccount, IDeposit, IInterestCalculation
{
    private decimal loanPeriod;

    // Propery
    public decimal LoanPeriod
    {
        get { return this.loanPeriod; }
        set
        {
            if (value < 3)
            {
                throw new ArgumentOutOfRangeException("The Loan Period must be min 3 month!!!");
            }
            else
            {
                this.loanPeriod = value;
            }
        }
    }

    // Constructor
    public LoanAccount(Customer customer, decimal balance, decimal interestRate, decimal loanPeriod) : base(customer, balance, interestRate)
    {
        this.LoanPeriod = loanPeriod;
    }

    // Methods
    public void Deposit(decimal value)
    {
        this.Balance += value;
    }
    public decimal CalculateInterestRate()
    {
        if (this.Customer is IndividualCustomer)
        {
            return (this.InterestRate * this.Balance) * (this.LoanPeriod - 3);
        }
        else
        {
            return (this.InterestRate * this.Balance) * (this.LoanPeriod - 2);
        }
    }
    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendLine(new string('-', 10));
        print.AppendLine("Loan Account - Owner: " + this.Customer.CustomerName);
        print.AppendLine("Balance - " + this.Balance + ", InterestRate - " + this.InterestRate + ";");
        print.AppendLine("Loan Period - " + this.LoanPeriod + ", Interest amount for the period - " + CalculateInterestRate() + ";");
        print.AppendLine(new string('-', 10));

        return print.ToString();
    }
}