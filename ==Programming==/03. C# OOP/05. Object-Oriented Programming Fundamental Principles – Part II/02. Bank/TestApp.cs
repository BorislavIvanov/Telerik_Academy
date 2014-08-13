//02. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.
//
//All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. 
//Loan and mortgage accounts can only deposit money.
//
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: 
//number_of_months * interest_rate.
//
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//
//Deposit accounts have no interest if their balance is positive and less than 1000.
//
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//
//Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, 
//base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.

using System;

class TestApp
{
    static void Main()
    {
        // Customers
        Customer[] customers = new Customer[4];
        customers[0] = new IndividualCustomer("Iliqn Petrov", 59784, "0894719648");
        customers[1] = new CompanieCustomer("Kiril Iliev", 81746, "0881446720");
        customers[2] = new IndividualCustomer("Nikolai Grancharov", 91002, "0874100359");
        customers[3] = new CompanieCustomer("Kiril Slavqnov", 00147, "0886979231");

        // Accounts
        DepositAccount firstDeposit = new DepositAccount(customers[0], 3000, 0.10m, 12);

        BankAccount[] accounts = new BankAccount[5];
        accounts[0] = firstDeposit;
        accounts[1] = new LoanAccount(customers[1], 5000, 0.08m, 6);
        accounts[2] = new LoanAccount(customers[2], 5000, 0.08m, 6);
        accounts[3] = new MortgageAccount(customers[2], 22900, 0.11m, 48);
        accounts[4] = new MortgageAccount(customers[3], 22900, 0.11m, 48);

        // Print 1
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("First Print ...");
        Console.ResetColor();
        foreach (var item in accounts)
        {
            Console.WriteLine(item);
            Console.WriteLine();
        }

        // Withdraw & Deposit
        firstDeposit.Withdraw(250);
        firstDeposit.Deposit(600);

        // Print 2
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Second Print ...");
        Console.ResetColor();
        Console.WriteLine(accounts[0]);
        Console.ReadLine();
    }
}