//08. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Numerics;

class BinaryRepresentationOfShort
{
    public static BigInteger ConvertDecimalToBin(short number)
    {
        BigInteger result = 0;
        BigInteger power = 1;
        if (number < 0)
        {
            result = 1111111111111111;
            number += 1;
        }

        while (number != 0)
        {
            result += (number % 2) * power;
            number /= 2;
            power *= 10;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.Write("Please Enter number in Short range type: ");
        short numberInDecimal = short.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Result: ");
        Console.WriteLine(ConvertDecimalToBin(numberInDecimal));
        Console.WriteLine();
    }
}

