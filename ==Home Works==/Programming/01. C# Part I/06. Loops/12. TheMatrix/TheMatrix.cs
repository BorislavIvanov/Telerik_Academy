//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:
//N=3       N=4
//1 2 3     1 2 3 4
//2 3 4     2 3 4 5
//3 4 5     3 4 5 6
//          4 5 6 7

using System;

class TheMatrix
{
    public static void fun()
    {
        Console.WindowHeight = 57;
        Console.WindowWidth = 100;
    }
    static void Main()
    {
        TheMatrix.fun();

        Console.Title = "The Matrix";

        //Input Number N;
        Console.Write("Please Enter Number N (1<N<20): ");
        string inputN = Console.ReadLine();
        int numberN;
        while (!int.TryParse(inputN, out numberN) || 1 > numberN || 19 < numberN)
        {
            Console.Write("Please Enter Correct N Number (1<N<20): ");
            inputN = Console.ReadLine();
        }

        int number = 1;
        int count = -1;
        for (int i = 0; i < numberN; i++)
        {
            Console.WriteLine("\n\n");
            count++;
            number = count + 1;
            for (int j = 0; j < numberN; j++)
            {
                Console.Write(" {0,3} ", number);
                number++;
            }
        }

        Console.WriteLine("\n");
    }
}

