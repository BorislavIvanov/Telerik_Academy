//A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
//bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables
//needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        Console.Title = "BankAccount";

        string firstName, middleName, lastName;
        decimal accountBalance;
        string bankName, IBAN, BIC, creditCard1, creditCard2, creditCard3;

        //

        Console.Write("Type your First name: ");
        firstName = (Console.ReadLine());
        Console.Write("Type your Middle name: ");
        middleName = (Console.ReadLine());
        Console.Write("Type your Last name: ");
        lastName = (Console.ReadLine());

        Console.WriteLine("\n|| Hello " + firstName + " " + middleName + " " + lastName + " ||");
        Console.WriteLine("|| This is information about your account ||");
        Console.WriteLine(new string('-', 44));

        bankName = "UniCredit Bulbank";
        IBAN = "BG 25 84923 752145896247";
        BIC = "UNCRBGSF";
        creditCard1 = "5813 5369 8795 5412";
        creditCard2 = "7586 4128 2473 3247";
        creditCard3 = "2453 5478 1249 6501";
        accountBalance = 26584.60m;

        Console.WriteLine("You use " + bankName + " | BIC - {0} || IBAN - {1} |", BIC, IBAN);
        Console.WriteLine(new string('-', 10));
        Console.WriteLine("Your account balance is " + accountBalance + " lv");
        Console.WriteLine("(Last account information Update:" + System.DateTime.Now + ")");
        Console.WriteLine(new string('-', 10));
        Console.WriteLine("You have 3 active Credit Cards:");
        Console.WriteLine("\n*First active  - {0}\n*Second active - {1}\n*Third active  - {2}", creditCard1, creditCard2, creditCard3);
        Console.WriteLine(new string('-', 10));
    }
}

