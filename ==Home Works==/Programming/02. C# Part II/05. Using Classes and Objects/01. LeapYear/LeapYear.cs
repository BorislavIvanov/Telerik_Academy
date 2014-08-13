// 01. Write a program that reads a year from the console and checks whether it is a leap.
// Use DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Please Type any Year: ");
        ushort theYear = ushort.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(theYear + " is leap?: " + DateTime.IsLeapYear(theYear));
        Console.WriteLine();
    }
}

