//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class BooleanExpression
{
    static void Main()
    {
        Console.Title = "Boolean Expression";

        Console.Write("Type value: ");
        int theValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Can be divided by 7 and 5 in the same time: " + (theValue % 5 == 0 && theValue % 7 == 0));

        // ... or ... Console.Writeline("Can be divided by 7 and 5 in the same time: " + (theValue % 35 == 0));

    }
}

