//A marketing firm wants to keep record of its employees.
//Each record would have the following characteristics:
//first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).
//Declare the variables needed to keep the information
//for a single employee using appropriate data types and descriptive names.

using System;

class MarketingFirm
{
    static void Main()
    {
        Console.Title = "Marketing Firm";

        string firstName, lastName;
        byte age;
        char gender;
        ushort personalID;
        uint uniqueNumber;

        firstName = "BoBBy";
        lastName = "***";
        age = 90;
        gender = 'M';
        personalID = 00963;
        uniqueNumber = 27560001;

        Console.WriteLine("Information about: {0} {1} |Age - {2}||Gender - {3}|", firstName, lastName, age, gender);
        Console.WriteLine("|PersonalID: {0}\n|UniqeNumber: {1}", personalID, uniqueNumber);
    }
}

