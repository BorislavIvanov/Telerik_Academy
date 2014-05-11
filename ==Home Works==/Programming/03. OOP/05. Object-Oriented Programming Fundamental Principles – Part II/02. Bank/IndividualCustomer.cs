using System;

class IndividualCustomer : Customer
{
    // Constructor
    public IndividualCustomer(string customerName, int bankNumber, string gsm) : base(customerName, bankNumber, gsm)
    {
    }

    // Method
    public override string ToString()
    {
        string print = String.Format("Individual Customer - Name: {0}, BankNumber: {1}, GSM: {2}", this.CustomerName, this.BankNumber, this.GSM);

        return print;
    }
}