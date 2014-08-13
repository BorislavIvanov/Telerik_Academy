//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Title = "Maximal Increasing Sequence";

        Console.Write("Enter the count of numbers: ");
        string entrCount = Console.ReadLine();
        int Count;

        while (!int.TryParse(entrCount, out Count) || (Count < 1))
        {
            Console.Write("Please type correct count (number > 0): ");
            entrCount = Console.ReadLine();
        }

        Console.WriteLine();

        int[] arr = new int[Count];

        for (int i = 0; i < Count; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            string entrArri = Console.ReadLine();
            while (!int.TryParse(entrArri, out arr[i]))
            {
                Console.Write("Please type integer number (number >= 0): ");
                entrArri = Console.ReadLine();
            }
        }

        Console.WriteLine();

        string sequence = "";
        int lenght = 1;
        string maxsequence = "";
        int maxlenght = 1;

        for (int i = 0; i < Count - 1; i++)
        {
            if (sequence.Length == 0)
            {
                sequence += arr[i] + " "; 
            }
            
            if (arr[i] < arr[i + 1])
            {
                sequence += arr[i + 1] + " ";
                lenght++;

                if (lenght >= maxlenght)
                {
                    maxsequence = sequence;
                    maxlenght = lenght;
                }
            }

            else
            {
                sequence = "";
                lenght = 1;
            }
        }

        Console.WriteLine("( " + maxsequence + ")");
        Console.WriteLine();
    }
}

