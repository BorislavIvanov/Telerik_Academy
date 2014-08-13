//17. Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//    and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;

class AfterSixHoursAndThirtyMin
{
    static void Main()
    {
        Console.WriteLine("Enter Date and Time(example: 24.08.2013 16:00:00): ");
        string inputDateTime = Console.ReadLine();

        DateTime dateTime = DateTime.ParseExact(inputDateTime, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        dateTime = dateTime.AddHours(6.5);

        Console.WriteLine();
        Console.WriteLine("Result: ");
        Console.WriteLine("{0} - {1}", dateTime, dateTime.ToString("dddd", new CultureInfo("bg-BG")));
        Console.WriteLine();
    }
}

