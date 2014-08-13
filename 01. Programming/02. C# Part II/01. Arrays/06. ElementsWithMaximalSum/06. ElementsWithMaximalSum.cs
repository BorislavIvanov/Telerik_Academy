//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class ElementsWithMaximalSum
{
    static void Main()
    {
        Console.Title = "Elements With Maximal Sum";

        //Number N;
        Console.Write("Please Enter number N: ");
        string entrNumberN = Console.ReadLine();
        int numberN;
        while (!int.TryParse(entrNumberN, out numberN) || numberN < 1)
        {
            Console.Write("Enter valid N number (N > 0): ");
            entrNumberN = Console.ReadLine();
        }

        //Number K;
        Console.Write("Please Enter number K: ");
        string entrNumberK = Console.ReadLine();
        int numberK;
        while (!int.TryParse(entrNumberK, out numberK) || numberK > numberN || numberK < 1)
        {
            Console.Write("Enter valid K number (K < N & K > 0): ");
            entrNumberK = Console.ReadLine();
        }

        Console.WriteLine();

        int[] arr = new int[numberN];

        for (int i = 0; i < numberN; i++)
        {
            Console.Write("Enter Element " + i + ": ");
            string arrI = Console.ReadLine();
            while (!int.TryParse(arrI, out arr[i]))
            {
                Console.Write("Type correct number (num > 0): ");
                arrI = Console.ReadLine();
            }
        }

        //int numberN = 6;
        //int numberK = 3;
        //int[] arr = { 1, 2, 9, 8, 7, 6 };

        string bestSequense = "";
        int sum = 0;
        int bestSum = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            string sequence = "";

            if (i + numberK > arr.Length)
            {
                break;
            }

            for (int j = i; j < i + numberK; j++)
            {
                sum += arr[j];
                sequence += " " + arr[j];
            }

            if (sum > bestSum)
            {
                bestSum = sum;
                bestSequense = sequence;
            }

            sum = 0;

        }
        Console.WriteLine();
        Console.WriteLine(bestSequense + " = " + bestSum);
        Console.WriteLine();
    }
}

