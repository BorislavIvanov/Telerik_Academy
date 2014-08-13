using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        DateTime current = new DateTime(year, month, day);
        DateTime next = current.AddDays(1);

        Console.WriteLine("{0}.{1}.{2}", next.Day, next.Month, next.Year);
    }
}