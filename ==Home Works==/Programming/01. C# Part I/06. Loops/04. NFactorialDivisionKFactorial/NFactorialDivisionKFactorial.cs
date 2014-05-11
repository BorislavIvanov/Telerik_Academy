//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class NFactorialDivisionKFactorial
{
    static void Main()
    {
        Console.Title = "N Factorial Division K Factorial";

        Console.WriteLine("Enter number K and number N (1<K<N)");

        //Input for Number K;
        Console.Write("\nPlease Enter number K for K!: ");
        string inputK = Console.ReadLine();
        int numberK;
        while (!int.TryParse(inputK, out numberK) || numberK < 2)
        {
            Console.Write("Please Enter Valid K Number (K > 1): ");
            inputK = Console.ReadLine();
        }

        //Input for Number N;
        Console.Write("\nPlease Enter number N for N!: ");
        string inputN = Console.ReadLine();
        int numberN;
        while (!int.TryParse(inputN, out numberN) || numberN < (numberK + 1))
        {
            Console.Write("Please Enter Valid N Number (N > K): ");
            inputN = Console.ReadLine();
        }
        
        decimal factorialK = 1;

        for (int k = 1; k <= numberK; k++)
        {
            factorialK *= k;
        }

        decimal factorialN = 1;

        for (int n = 1; n <= numberN; n++)
        {
            factorialN *= n;
        }

        Console.Write("\nN!/K! = {0}!/{1}! = ", numberN, numberK);
        Console.WriteLine(factorialN/factorialK);
    }
}

