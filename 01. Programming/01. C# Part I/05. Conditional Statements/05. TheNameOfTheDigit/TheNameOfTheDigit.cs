//Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

class TheNameOfTheDigit
{
    static void Main()
    {
        Console.Title = "TheNameOfTheDigit";

        Console.Write("Type one digit from 0 to 9: ");
        string theDigit = Console.ReadLine();

        switch (theDigit)
        {
            case "0":
                Console.WriteLine("\n{0} - ZERO\n", theDigit);
                break;
            case "1":
                Console.WriteLine("\n{0} - ONE\n", theDigit);
                break;
            case "2":
                Console.WriteLine("\n{0} - TWO\n", theDigit);
                break;
            case "3":
                Console.WriteLine("\n{0} - Three\n", theDigit);
                break;
            case "4":
                Console.WriteLine("\n{0} - FOUR\n", theDigit);
                break;
            case "5":
                Console.WriteLine("\n{0} - FIVE\n", theDigit);
                break;
            case "6":
                Console.WriteLine("\n{0} - SIX\n", theDigit);
                break;
            case "7":
                Console.WriteLine("\n{0} - SEVEN\n", theDigit);
                break;
            case "8":
                Console.WriteLine("\n{0} - EIGHT\n", theDigit);
                break;
            case "9":
                Console.WriteLine("\n{0} - NINE\n", theDigit);
                break;
            default:
                Console.WriteLine("\nError!!! Type number from 0 to 9 not something else !!!\n");
                break;
        }
    }
}

