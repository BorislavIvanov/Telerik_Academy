//In the combinatorial mathematics, the Catalan numbers are calculated by the formula: (2*n)! / (n + 1)! * n!
//Write a program to calculate the Nth Catalan number by given N.
//P.S. Exercise 9 = Exercise 10

using System;
using System.Numerics;

class CatalanFormula
{
    static void Main()
    {
        Console.Title = "Catalan Formula";

        //Input for Number N;
        Console.Write("\nPlease Enter number n (n>=0): ");
        string inputN = Console.ReadLine();
        int numberN;
        while (!int.TryParse(inputN, out numberN) || numberN < 0)
        {
            Console.Write("Please Enter Valid n Number (n>=0): ");
            inputN = Console.ReadLine();
        }

        if (numberN == 0)
        {
            Console.WriteLine("\nFor n=0, Cn is 1\n");
        }

        if (numberN != 0)
        {
            BigInteger factorialN = 1;
            for (int n = 1; n <= numberN; n++)
            {
                factorialN *= n;
            }

            BigInteger factorialNplus1 = 1;
            int numberNplus1 = numberN + 1;
            for (int j = 1; j <= numberNplus1; j++)
            {
                factorialNplus1 *= j;
            }

            BigInteger factorial2N = 1;
            int number2N = 2 * numberN;
            for (int k = 1; k <= number2N; k++)
            {
                factorial2N *= k;
            }

            BigInteger calcolationCN = factorial2N / (factorialNplus1 * factorialN);
            Console.WriteLine("\nFor n={0}, Cn is {1}\n", numberN, calcolationCN);
        }
    }
}

