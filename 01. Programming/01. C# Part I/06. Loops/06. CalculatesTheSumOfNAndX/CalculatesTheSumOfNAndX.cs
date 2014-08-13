//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class CalculatesTheSumOfNAndX
{
    static void Main()
    {
        Console.Title = "Calculates The Sum Of N And X";

        //Input for Number N;
        Console.Write("\nPlease Enter number N: ");
        string inputN = Console.ReadLine();
        int numberN;
        while (!int.TryParse(inputN, out numberN))
        {
            Console.Write("Please Enter Valid N: ");
            inputN = Console.ReadLine();
        }

        //Input for Number X;
        Console.Write("\nPlease Enter number X: ");
        string inputX = Console.ReadLine();
        int numberX;
        while (!int.TryParse(inputX, out numberX))
        {
            Console.Write("Please Enter Valid X: ");
            inputX = Console.ReadLine();
        }

        Console.WriteLine("\n");

        Console.Write("1");

        decimal factorialN = 1;
        decimal resultX = 1;

        for (int i = 0, n = 1; i < numberN; i++, n++)
        {
            factorialN *= n;
            resultX *= numberX;

            Console.Write(" + {0}/{1}", factorialN, resultX);
        }

        Console.Write(" = " + (1 + (factorialN / resultX)));
        Console.WriteLine("\n");
    }
}

