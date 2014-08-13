//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;

    class NFactorialMultiplyKFactorial
    {
        static void Main()
        {
            Console.Title = "N Factorial Multiply K Factorial";

            Console.WriteLine("Enter number N and number K (1<N<K)");

            //Input for Number N;
            Console.Write("\nPlease Enter number N for N!: ");
            string inputN = Console.ReadLine();
            int numberN;
            while (!int.TryParse(inputN, out numberN) || numberN < 2)
            {
                Console.Write("Please Enter Valid N Number (N > 1): ");
                inputN = Console.ReadLine();
            }

            //Input for Number K;
            Console.Write("\nPlease Enter number K for K!: ");
            string inputK = Console.ReadLine();
            int numberK;
            while (!int.TryParse(inputK, out numberK) || numberK < (numberN + 1))
            {
                Console.Write("Please Enter Valid K Number (K > N): ");
                inputK = Console.ReadLine();
            }

            decimal factorialN = 1;

            for (int n = 1; n <= numberN; n++)
            {
                factorialN *= n;
            }

            decimal factorialK = 1;

            for (int k = 1; k <= numberK; k++)
            {
                factorialK *= k;
            }

            decimal factorialKminusN = 1;
            int numberKminusN = (numberK - numberN);

            for (int j = 1; j <= numberKminusN; j++)
            {
                factorialKminusN *= j;
            }

            Console.Write("\nN!*K! / (K-N)! = {0}!*{1}! / ({1} - {0}) = ", numberN, numberK);
            Console.WriteLine((factorialN * factorialK) / factorialKminusN);
        }
    }

