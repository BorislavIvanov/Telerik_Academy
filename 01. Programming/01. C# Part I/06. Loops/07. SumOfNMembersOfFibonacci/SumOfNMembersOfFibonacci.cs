//Write a program that reads a number N and calculates the sum of the first N members of 
//the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;
using System.Numerics;

class SumOfNMembersOfFibonacci
{
    static void Main()
    {
        Console.Title = "Sum Of N Members Of Fibonacci";

        Console.Write("Enter (N) How many members of Fibonacci you want: ");
        string inputN = Console.ReadLine();
        int numberN;
        while (!int.TryParse(inputN, out numberN) || numberN < 0)
        {
            Console.Write("Enter Correct N Number (N >= 0): ");
            inputN = Console.ReadLine();
        }
                
        BigInteger prevOne = 0;
        BigInteger prevTwo = 1;
        BigInteger fibonacciNumber = 0;
        BigInteger x = 0;

        if (numberN == 0)
        {
            Console.WriteLine("Sum of first 0 Fibonacci Numbers is: 0");
        }

        if (numberN == 1)
        {
            Console.WriteLine("Sum of first 1 Fibonacci Number is: 1");
        }

        if (numberN != 0 && numberN != 1)
        {
            for (int i = 2; i <= numberN; i++)
            {
                fibonacciNumber = prevOne + prevTwo;
                prevOne = prevTwo;
                prevTwo = fibonacciNumber;
                x += fibonacciNumber;
            }
            Console.Write("\nSum of first {0} Fibonacci Numbers is: ", numberN);
            Console.WriteLine(x + 1);
            Console.WriteLine("\n");
        }
    }
}

