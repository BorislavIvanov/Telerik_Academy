//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class ThreeIntegerNumbers
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Element " + (i+1) + ": ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.Write("Enter the wanted sum: ");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Enter number of elements forming the amount: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int sum = 0;
        int columns = n, rows = (int)Math.Pow(2, n) - 1, row;
        int[] sumSeq = new int[n];
        bool addSum;

        for (row = rows - 1; row > 1; row--)
        {
            int remainder = row;
            sum = 0;
            sumSeq = new int[n];
            int sumIdx = 0;
            int column = 0;

            for (column = 0; column < columns; column++)
            {
                if (remainder % 2 != 0)
                {
                    addSum = true;
                    for (int p = 0; p < sumIdx; p++)
                    {
                        if (array[column] == sumSeq[p])
                        {
                            addSum = false;
                            break;
                        }
                    }
                    if (addSum == true)
                    {
                        sumSeq[sumIdx++] = array[column];
                        sum += array[column];
                    }
                }
                remainder = remainder / 2;
            }
            if (sum == s)
            {
                if (sumIdx == k)
                {
                    for (int i = 0; i < sumIdx; i++)
                    {
                        Console.Write("{0} ", sumSeq[i]);
                    }
                    break;
                }
            }
        }
        if (row == 1)
            Console.WriteLine("No elements found!");
        else
            Console.WriteLine("");

        Console.WriteLine();
    }
}

