using System;

class OddNumber
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        long[] massiveOfNumbers = new long[numberN];

        for (int i = 0; i < numberN; i++)
        {
            long number = long.Parse(Console.ReadLine());
            massiveOfNumbers[i] = number;
        }

        long calculation = massiveOfNumbers[0];

        for (int i = 1; i < numberN; i++)
        {
            calculation ^= massiveOfNumbers[i];
        }

        Console.WriteLine(calculation);
    }
}