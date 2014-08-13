using System;
using System.Text;

abstract class BankAccount
{
    private Customer customer;
    private decimal balance;
    private decimal interestRate;

    // Propertys
    public Customer Customer { get; set; }

    public decimal Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }

    public decimal InterestRate
    {
        get { return this.interestRate; }
        set { this.interestRate = value; }
    }

    // Constructor
    public BankAccount(Customer customer, decimal balance, decimal interestRate)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }
}