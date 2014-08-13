// 05. Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;

class NumberOfWorkDays
{

    static void Main()
    {
        Console.Write("Enter a Date (example: DD-MM-YYYY): ");
        string theDate = Console.ReadLine();

        DateTime startDate = DateTime.Today;
        DateTime pointedDate = DateTime.Parse(theDate);

        if (startDate > pointedDate)
        {
            DateTime x = startDate;
            startDate = pointedDate;
            pointedDate = x;
        }

        Console.WriteLine();
        Console.WriteLine("From: {0:dd/MM/yyyy}", startDate);
        Console.WriteLine("To: {0:dd/MM/yyyy}", pointedDate);

        int timeLenght = (pointedDate - startDate).Days;

        int countOfDays = 0;

        // Praznici - nachalo;

        List<DateTime> holidays = new List<DateTime>();

        int startYear = DateTime.Today.Year;
        int endYear = pointedDate.Year;
        int yearsOfHolidays = endYear - startYear;

        if (yearsOfHolidays == 0)
        {
            yearsOfHolidays = 1;
        }

        int theYear = startYear;
        int thePlace = -1;
        
        for (int i = 0; i < yearsOfHolidays; i++)
        {
            holidays.Add(new DateTime(theYear, 01, 01));
            holidays.Add(new DateTime(theYear, 03, 03));
            holidays.Add(new DateTime(theYear, 05, 01));
            holidays.Add(new DateTime(theYear, 05, 06));
            holidays.Add(new DateTime(theYear, 05, 24));
            holidays.Add(new DateTime(theYear, 09, 06));
            holidays.Add(new DateTime(theYear, 09, 22));
            holidays.Add(new DateTime(theYear, 11, 01));
            holidays.Add(new DateTime(theYear, 12, 24));
            holidays.Add(new DateTime(theYear, 12, 25));
            holidays.Add(new DateTime(theYear, 12, 26));
            holidays.Add(new DateTime(theYear, 12, 31));

            thePlace = thePlace + 12;
            theYear++;
        }
        
        // Praznici - krai;

        for (int i = 0; i < timeLenght; i++)
        {
            startDate = startDate.AddDays(1);
            if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                bool isHoliday = false;

                for (int j = 0; j < holidays.Count; j++)
                {
                    if (startDate == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (isHoliday == false)
                {
                    countOfDays++;
                }
            }
        }

        Console.WriteLine("... have {0} workdays :)", countOfDays);
        Console.WriteLine();
    }
}

