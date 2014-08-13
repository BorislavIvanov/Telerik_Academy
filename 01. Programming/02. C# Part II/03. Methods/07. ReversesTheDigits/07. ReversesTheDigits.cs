//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;
using System.Collections.Generic;

class ReversesTheDigits
{
    static void ArrayReverse(ulong theNumber)
    {
        ulong digit = 0;
        List<ulong> listOfNumber = new List<ulong>();
        while (theNumber != 0)
        {
            digit = theNumber % 10;
            theNumber = theNumber / 10;
            listOfNumber.Add(digit);
        }
        foreach (int digitOfNumber in listOfNumber)
        {
            Console.Write(digitOfNumber);
        }
    }
    static void Main()
    {
        Console.Write("Please enter integer Number: ");
        ulong number = ulong.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Result: ");
        ReversesTheDigits.ArrayReverse(number);

        Console.WriteLine("\n");
    }
}

