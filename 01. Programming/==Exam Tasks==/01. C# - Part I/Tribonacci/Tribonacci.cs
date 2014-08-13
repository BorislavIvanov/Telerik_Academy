using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        BigInteger numberN = BigInteger.Parse(Console.ReadLine());

        BigInteger calculation = 0;

        if (numberN == 1)
        {
            Console.WriteLine(first);
        }

        else if (numberN == 2)
        {
            Console.WriteLine(second);
        }

        else if (numberN == 3)
        {
            Console.WriteLine(third);
        }

        else
        {
            for (int i = 3; i < numberN; i++)
            {
                calculation = first + second + third;
                first = second;
                second = third;
                third = calculation;
            }

            Console.WriteLine(calculation);
        }
    }
}

