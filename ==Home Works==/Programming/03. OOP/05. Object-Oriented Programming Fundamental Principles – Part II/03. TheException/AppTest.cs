//03. Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].
//
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers 
//in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

using System;

class AppTest
{
    static void Main()
    {
        try
        {
            NumberValidator();
            DateValidator();
        }
        catch (Exception exception)
        {
            Console.WriteLine("Error!: " + exception.Message);
        }
    }

    private static void DateValidator()
    {
        DateTime min = new DateTime(2000, 01, 01);
        DateTime max = new DateTime(2013, 10, 15);

        Console.WriteLine("Enter Date in range {0} - {1}: ", min, max);
        DateTime date = DateTime.Parse(Console.ReadLine());

        if (min > date || date > max)
        {
            throw new InvalidRangeException<DateTime>(min, max);
        }
        else
        {
            Console.WriteLine("Date {0} is valid!", date);
        }
    }

    private static void NumberValidator()
    {
        int min = 0;
        int max = 100;

        Console.Write("Enter one number in range {0} - {1}: ", min, max);
        int number = int.Parse(Console.ReadLine());

        if (min > number || number > max)
        {
            throw new InvalidRangeException<int>(min, max);
        }
        else
        {
            Console.WriteLine("Number {0} is valid!", number);
        }
    }
}