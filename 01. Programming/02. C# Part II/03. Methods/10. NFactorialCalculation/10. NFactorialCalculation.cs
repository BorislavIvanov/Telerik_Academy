//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
//!!!Hint-a ne e dopulnitelno uslovie a prosto savet.

using System;
using System.Collections.Generic;
using System.Numerics;

class NFactorialCalculation
{
    static void Main()
    {
        Console.Write("Enter the n! Number in range from 0 to 100: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        FactorialCalculation(number);

        Console.WriteLine();

    }

    private static void FactorialCalculation(int number)
    {
        BigInteger factorial = 1;

        if (number == 0)
        {
            Console.WriteLine("0! = 1");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                Console.WriteLine("{0}! = {1}", i, factorial);
            }
        }
    }
}


