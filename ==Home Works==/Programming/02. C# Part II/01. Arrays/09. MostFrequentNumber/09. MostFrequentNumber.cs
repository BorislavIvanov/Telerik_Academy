//Write a program that finds the most frequent number in an array. 
//Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.Title = "Most Frequent Number";

        Console.Write("Please enter the count of numbers: ");
        string entrLenght = Console.ReadLine();
        int lenght;
        while (!int.TryParse(entrLenght, out lenght) || lenght < 1)
        {
            Console.Write("Please correct value (num > 0): ");
            entrLenght = Console.ReadLine();
        }

        Console.WriteLine();

        int[] arr = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            string entrNum = Console.ReadLine();
            while (!int.TryParse(entrNum, out arr[i]))
            {
                Console.Write("Enter correct number (0 <= number <= 9): ");
                entrNum = Console.ReadLine();
            }
        }

        //Test:
        //int lenght = 13;
        //int[] arr = { 4, 1, 1, 1, 2, 3, 4, 4, 1, 2, 4, 1, 1 };

        int number = int.MinValue;
        int count = 0;
        int bestNumber = int.MinValue;
        int bestCount = 0;

        for (int i = 0; i < lenght; i++)
        {
            for (int j = 0; j < lenght; j++)
            {
                if (arr[i] == arr[j])
                {
                    number = arr[i];
                    count++;
                }

                if (bestCount <= count)
                {
                    bestNumber = number;
                    bestCount = count;
                }
            }

            number = int.MinValue;
            count = 0;
        }

        Console.WriteLine();

        Console.WriteLine(bestNumber + " -> " + "( " +bestCount + " time/s)");

        Console.WriteLine();
    }
}

