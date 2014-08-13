using System;

class ExcelColumns
{
    static void Main()
    {
        int numberOfDigits = int.Parse(Console.ReadLine());

        int[] digits = new int[numberOfDigits];
        long[] exponents = new long[numberOfDigits];

        for (int i = numberOfDigits - 1; i >= 0; i--)
        {
            digits[i] = (char.Parse(Console.ReadLine()) - '@');
        }

        for (int i = 0; i < numberOfDigits; i++)
        {
            exponents[i] = (long)Math.Pow(26, i);
        }

        long calculation = 0;

        for (int i = 0; i < numberOfDigits; i++)
        {
            calculation += (digits[i] * exponents[i]);
        }

        Console.WriteLine(calculation);
    }
}