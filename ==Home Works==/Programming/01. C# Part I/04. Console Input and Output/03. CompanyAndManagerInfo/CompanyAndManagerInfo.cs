//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number. Write a program
//that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyAndManagerInfo
{
    static void Main()
    {
        Console.Title = "Company And Manager Info";

        //Company Info.
        Console.WriteLine("Fill the Company Information.");
        Console.WriteLine(new string ('-', 15));

        Console.Write("Company name: ");
        string companyName = (Console.ReadLine());

        Console.Write("Company address: ");
        string companyAddress = (Console.ReadLine());

        Console.Write("Company phone number: ");
        string companyPhoneNum = (Console.ReadLine());

        Console.Write("Company fax number: ");
        string companyFaxNum = (Console.ReadLine());

        Console.Write("Company web site: ");
        string companyWebSite = (Console.ReadLine());


        Console.WriteLine(new string ('=', 20));

        //Manager Info.
        Console.WriteLine("\nFill the Manager Information.");
        Console.WriteLine(new string('-', 15));

        Console.Write("Company Manager first name: ");
        string managerFirstName = (Console.ReadLine());

        Console.Write("Company Manager last name: ");
        string managerLastName = (Console.ReadLine());

        Console.Write("Company Manager Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Company Manager Phone number: ");
        string managerPhoneNum = (Console.ReadLine());

        //Finished Company and Manager information filling.

        //Printing the Information ...

        Console.Clear();

        Console.WriteLine("Company Information:");
        Console.WriteLine(new string ('~', 20));

        Console.WriteLine("/_\\ Company name is - {0}", companyName);
        Console.WriteLine("/_\\ Company address is - {0}", companyAddress);
        Console.WriteLine("/_\\ Company phone number - {0}", companyPhoneNum);
        Console.WriteLine("/_\\ Company fax number- {0}", companyFaxNum);
        Console.WriteLine("/_\\ Company Web site - {0}", companyWebSite);
        Console.WriteLine("/_\\ The Company Manager name is {0} {1}", managerFirstName, managerLastName);

        Console.WriteLine("\nManager Information:");
        Console.WriteLine(new string('~', 20));

        Console.WriteLine("/_\\ Names: {0} {1}", managerFirstName, managerLastName);
        Console.WriteLine("/_\\ Age: {0}", managerAge);
        Console.WriteLine("/_\\ Phone Number: {0}", managerPhoneNum);

        Console.WriteLine(new string ('=', 30));

        Console.WriteLine("This information is from " + DateTime.Now);

        Console.WriteLine(new string('=', 30));
               
    }
}

