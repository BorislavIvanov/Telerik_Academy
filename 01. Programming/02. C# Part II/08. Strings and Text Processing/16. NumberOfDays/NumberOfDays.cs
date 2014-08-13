//16. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;

class NumberOfDays
{
    static void Main()
    {
        Console.Write("Enter The First Date(example: 27.02.2006): ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter The Second Date(example: 3.03.2004): ");
        string secondDate = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        if (startDate > endDate)
        {
            DateTime x = startDate;
            startDate = endDate;
            endDate = x;
        }

        Console.WriteLine();
        Console.Write("Result: ");
        Console.WriteLine((endDate - startDate).TotalDays);
        Console.WriteLine();
    }
}

