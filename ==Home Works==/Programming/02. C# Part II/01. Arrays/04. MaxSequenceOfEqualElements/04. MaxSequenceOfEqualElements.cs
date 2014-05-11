//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        Console.Title = "Max Sequence Of Equal Elements";

        Console.Write("Enter the count of numbers: ");
        string entrCount = Console.ReadLine();
        int Count;

        while (!int.TryParse(entrCount, out Count) || (Count < 1))
        {
            Console.Write("Please type correct count (number > 0): ");
            entrCount = Console.ReadLine();
        }

        int[] arr = new int[Count];

        for (int i = 0; i < Count; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            string entrArri = Console.ReadLine();
            while (!int.TryParse(entrArri, out arr[i]))
            {
                Console.Write("Please type integer number: ");
                entrArri = Console.ReadLine();
            }
        }

        int number = int.MinValue;
        int lenght = 1;
        int bestNumber = int.MinValue;
        int bestLenght = 1;

        for (int i = 0; i < Count - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                number = arr[i];
                lenght++;

                if (lenght >= bestLenght)
                {
                    bestNumber = number;
                    bestLenght = lenght;
                }
            }

            else
            {
                number = arr[i + 1];
                lenght = 1;
            }
        }

        Console.WriteLine();

        for (int i = 1; i <= bestLenght; i++)
        {
            Console.Write(bestNumber);

            if (i < bestLenght)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

