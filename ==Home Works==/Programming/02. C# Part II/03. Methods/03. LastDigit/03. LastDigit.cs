//03.Write a method that returns the last digit of given integer as an English word.
//Examples: 512  "two", 1024  "four", 12309  "nine".

using System;


class LastDigit
{
    static ulong FindingLastDigit(ulong number)
    {
        ulong lastDigit = number % 10;
        return lastDigit;
    }
    static string LastDigitName(ulong theDigit)
    {
        string digitName = "";
        switch (theDigit)
        {
            case 0: digitName = "Zero";
                break;
            case 1: digitName = "One";
                break;
            case 2: digitName = "Two";
                break;
            case 3: digitName = "Three";
                break;
            case 4: digitName = "Four";
                break;
            case 5: digitName = "Five";
                break;
            case 6: digitName = "Six";
                break;
            case 7: digitName = "Seven";
                break;
            case 8: digitName = "Eight";
                break;
            case 9: digitName = "Nine";
                break;
        }
        return digitName;
    }
    static void Main()
    {
        Console.Write("Enter the Number: ");
        ulong theNumber = ulong.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("The last Digit {0} in English word is - {1}", FindingLastDigit(theNumber),
                                                                            LastDigitName(FindingLastDigit(theNumber)));

        Console.WriteLine();
    }
}

