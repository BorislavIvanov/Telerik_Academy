using System;

class Customer
{
    private string customerName;
    private int bankNumber;
    private string gsm;

    // Propertys
    public string CustomerName
    {
        get { return this.customerName; }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Customer name cant be 0 symbols!!!");
            }
            else
            {
                this.customerName = value;
            }
        }
    }
    public int BankNumber
    {
        get { return this.bankNumber; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The Bank number must be positive number!!!");
            }
            else
            {
                this.bankNumber = value;
            }
        }
    }
    public string GSM
    {
        get { return this.gsm; }
        set
        {
            if (value.Length == 0  && value.Length > 10)
            {
                throw new ArgumentOutOfRangeException("GSM number must be more than 0 symbols and less than 11!!!");   
            }
            else
            {
                this.gsm = value;
            }
        }
    }

    // Constructor
    public Customer(string customerName, int bankNumber, string gsm)
    {
        this.CustomerName = customerName;
        this.BankNumber = bankNumber;
        this.GSM = gsm;
    }

    // Method
    public override string ToString()
    {
        string print = String.Format("Customer - Name: {0}, BankNumber: {1}, GSM: {2}", this.CustomerName, this.BankNumber, this.GSM);

        return print;
    }
}