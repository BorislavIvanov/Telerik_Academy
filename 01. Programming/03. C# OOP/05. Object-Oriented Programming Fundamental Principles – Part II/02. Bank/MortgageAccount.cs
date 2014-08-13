using System;
using System.Text;

class MortgageAccount : BankAccount, IDeposit, IInterestCalculation
{
    private decimal mortgagePeriod;

    // Property
    public decimal MortgagePeriod
    {
        get { return this.mortgagePeriod; }
        set
        {
            if (value < 12)
            {
                throw new ArgumentOutOfRangeException("The Mortgage Period must be min 3 month!!!");
            }
            else
            {
                this.mortgagePeriod = value;
            }
        }
    }

    // Constructor
    public MortgageAccount(Customer customer, decimal balance, decimal interestRate, decimal mortgagePeriod) : base(customer, balance, interestRate)
    {
        this.MortgagePeriod = mortgagePeriod;
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
            return (this.InterestRate * this.Balance) * (this.MortgagePeriod - 6);
        }
        else
        {
            return (((this.InterestRate * this.Balance) / 2) * 12) + ((this.InterestRate * this.Balance) * (this.MortgagePeriod - 12));
        }
    }

    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendLine(new string('-', 10));
        print.AppendLine("Mortgage Account - Owner: " + this.Customer.CustomerName);
        print.AppendLine("Balance - " + this.Balance + ", InterestRate - " + this.InterestRate + ";");
        print.AppendLine("Loan Period - " + this.MortgagePeriod + ", Interest amount for the period - " + CalculateInterestRate() + ";");
        print.AppendLine(new string('-', 10));

        return print.ToString();
    }
}