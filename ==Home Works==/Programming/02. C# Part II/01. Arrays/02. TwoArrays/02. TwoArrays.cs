//Write a program that reads two arrays from the console and compares them element by element.

using System;

class TwoArrays
{
    static void Main()
    {
        Console.Title = "Two Arrays";

        //Array One;
        Console.Write("Length of first Array?: ");
        string firstLength = Console.ReadLine();
        int firstArray;
        while (!int.TryParse(firstLength, out firstArray) || (firstArray < 1))
        {
            Console.Write("Please Type correct Length (number > 0): ");
            firstLength = Console.ReadLine();
        }

        string[] arrOne = new string[firstArray];

        for (int i = 0; i < firstArray; i++)
        {
            Console.Write("Position " + i + " of first array: ");
            
            arrOne[i] = Console.ReadLine();
        }
        ////

        Console.WriteLine();

        //Array Two;
        Console.Write("Length of second Array?: ");
        string secondLength = Console.ReadLine();
        int secondArray;
        while (!int.TryParse(secondLength, out secondArray) || (secondArray < 1))
        {
            Console.Write("Please Type correct Length (number > 0): ");
            secondLength = Console.ReadLine();
        }

        string[] arrTwo = new string[secondArray];

        for (int i = 0; i < secondArray; i++)
        {
            Console.Write("Position " + i + " of first array: ");

            arrTwo[i] = Console.ReadLine();
        }
        ////
        bool equal = true;

        if (arrOne.Length != arrTwo.Length)
        {
            equal = false;
            Console.WriteLine("\nThe arrays are equal: {0}",equal);
        }

        else
        {
            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] != arrTwo[i])
                {
                    equal = false;
                    break;
                }
            }
            Console.WriteLine("\nThe arrays are equal: {0}", equal);
        }
    }
}

