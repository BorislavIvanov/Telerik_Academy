//Write a program that finds the sequence of maximal sum in given array.
// Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaximalSumInArray
{
    static void Main()
    {
        Console.Title = "Maximal Sum InArray";

        Console.Write("Enter the lenght of the Array (lenght > 4): ");
        string entrLenght = Console.ReadLine();
        int lenght;
        while (!int.TryParse(entrLenght, out lenght) || lenght < 4)
        {
            Console.Write("Enter correct value (num > 0): ");
            entrLenght = Console.ReadLine();
        }

        Console.WriteLine();

        int[] arr = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter Number " + (i + 1) + ": ");
            string entrArrI = Console.ReadLine();
            while (!int.TryParse(entrArrI, out arr[i]))
            {
                Console.Write("Enter Correct Value!: ");
                entrArrI = Console.ReadLine();
            }
        }

        //Test:
        //int lenght = 10;
        //int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int sum = int.MinValue;
        string sequence = "";
        int maxSum = int.MinValue;
        string bigestSequence = "";

        for (int i = 0; i < lenght - 3; i++)
        {
            if (arr[i] + arr[i + 1] + arr[i + 2] + arr[i + 3] > sum)
            {
                sum = arr[i] + arr[i + 1] + arr[i + 2] + arr[i + 3];
                sequence = arr[i] + ", " + arr[i + 1] + ", " + arr[i + 2] + ", " + arr[i + 3];
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                bigestSequence = sequence;
            }
        }

        Console.WriteLine();
        Console.WriteLine(bigestSequence);
        Console.WriteLine();
    }
}

