//09. * Write a program that shows the internal binary representation of given 32-bit signed floating-point number
//in IEEE 754 format (the C# type float).
//Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;
using System.Collections.Generic;

class ConvertFloatToBinary
{
    static void Main()
    {
        Console.Write("Please enter one float number: ");
        float number = float.Parse(Console.ReadLine());

        int sign = 0;
        string exponent = null;
        List<int> mantissa = new List<int>();
        sign = FindSign(number);
        exponent = FindExponent(number);
        mantissa = FindMantissa(number);
        Console.WriteLine();
        Console.WriteLine("Sign   Exponent   Mantisa");
        Console.Write(sign + "      " + exponent + "   ");

        for (int counter = 0; counter < 23; counter++)
        {
            Console.Write(mantissa[counter]);
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    private static int FindSign(float number)
    {
        if (number >= 0)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    private static string FindExponent(float number)
    {
        if (number < 0)
        {
            number = -number;
        }
        string bin = Convert.ToString((int)number, 2);
        int exponent = bin.Length - 1 + 127;
        string stringExponent = Convert.ToString(exponent, 2);
        return stringExponent;
    }

    private static List<int> FindMantissa(float number)
    {
        List<int> Mantissa = new List<int>();
       
        if (number < 0)
        {
            number = -number;
        }
        
        int firstPart = (int)number;
        while (firstPart >= 2)
        {
            Mantissa.Add(firstPart % 2);
            firstPart /= 2;
        }
        
        Mantissa.Reverse();

        float secondPart = number % 1;
        while (secondPart != 0.0)
        {
            if (2 * secondPart >= 1)
            {
                Mantissa.Add(1);
            }
            else
            {
                Mantissa.Add(0);
            }
            secondPart = (2 * secondPart) % 1;
        }
        
        while (Mantissa.Count < 23)
        {
            Mantissa.Add(0);
        }
        return Mantissa;
    }
}

