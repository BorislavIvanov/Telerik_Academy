//02. Write a program to convert binary numbers to their decimal representation.

using System;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter one Binary Number: ");
        string binaryNumber = Console.ReadLine();

        int decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[binaryNumber.Length - i - 1] == '0')
            {
                continue;
            }
            decimalNumber += (int)Math.Pow(2, i);
        }
        Console.WriteLine();
        Console.WriteLine("Result: {0}", decimalNumber);
        Console.WriteLine();
    }
}

