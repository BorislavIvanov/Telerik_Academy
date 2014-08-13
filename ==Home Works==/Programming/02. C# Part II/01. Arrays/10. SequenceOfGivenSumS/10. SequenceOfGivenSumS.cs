//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class SequenceOfGivenSumS
{
    static void Main()
    {
        Console.Title = "Sequence Of Given Sum S";

        Console.Write("Emter the Sum of the Numbers: ");
        string entrSum = Console.ReadLine();
        int sum;
        while (!int.TryParse(entrSum, out sum))
        {
            Console.Write("Please enter correct value: ");
            entrSum = Console.ReadLine();
        }

        Console.Write("Enter the Count of the Numbers: ");
        string entrlenght = Console.ReadLine();
        int lenght;
        while (!int.TryParse(entrlenght, out lenght))
        {
            Console.Write("Please enter correct value: ");
            entrlenght = Console.ReadLine();
        }

        Console.WriteLine();

        int[] arr = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter " + (i + 1) + " number: ");
            string entrArrI = Console.ReadLine();
            while (!int.TryParse(entrArrI, out arr[i]))
            {
                Console.Write("Please enter correct value: ");
                entrArrI = Console.ReadLine();
            }
        }

        Console.WriteLine();

        //Test:
        //int sum = 5;
        //int lenght = 7;
        //int[] arr = { 2, 3, -3, 8, 1, 5, 0 };

        Console.Write("Result: ");

        int calcualtion = int.MinValue;
        string sequence = "";
        
        for (int i = 0; i < lenght; i++)
        {
            calcualtion = arr[i];
            sequence += arr[i] + " ";

            for (int j = i+1; j < lenght; j++)
            {
                calcualtion += arr[j];
                sequence += arr[j] + " ";

                if (calcualtion == sum)
                {
                    Console.Write(" ( " + sequence + ") ");
                    break;
                }
            }

            calcualtion = int.MinValue;
            sequence = "";
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

