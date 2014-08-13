//01. Write a program to convert decimal numbers to their binary representation.

//P.S. Покриването на случаите с отрицателни числа е необходимо на задачата за превръщане на short в binary.
//Тук просто се преобразуват неотрицателни числа.

using System;
using System.Collections.Generic;

class ConvertDecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter one Positive Decimal Number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        
        Print(DecimalToBinary(decimalNumber));

        // OR:
        /*
        Console.WriteLine();
        Console.Write("Result: ");
        Console.WriteLine(Convert.ToString(decimalNumber, 2));
        Console.WriteLine();
        */
    }

    static List<int> DecimalToBinary(int decimalNumber)
    {
        List<int> binaryNumber = new List<int>();

        while (decimalNumber > 0)
        {
            binaryNumber.Add(decimalNumber % 2);
            decimalNumber = decimalNumber / 2;
        }

        binaryNumber.Reverse();

        return binaryNumber;
    }

    static void Print(List<int> binaryNumber)
    {
        Console.WriteLine();
        Console.Write("Result: ");
        for (int i = 0; i < binaryNumber.Count; i++)
        {
            Console.Write("{0}", binaryNumber[i]);
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}

