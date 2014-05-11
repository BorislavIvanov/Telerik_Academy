//Write a program to read your age from the console and print how old you will be after 10 years.

using System;

class AfterTenYears
{
    static void Main()
    {
        Console.Write("Which Year you have been born?: ");
        int born = int.Parse(Console.ReadLine());
        int ageNow = DateTime.Now.Year - born;
        int yearsAfterTen = ageNow + 10;


        Console.WriteLine("Now you are {0} years old , after 10 years you will be at {1}.", ageNow, yearsAfterTen);

        Console.ReadLine();
    }
}

