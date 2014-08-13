//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class TwoCharArrays
{
    static void Main()
    {
        Console.Title = "Two Char Arrays";

        //Array One;
        Console.Write("Length of first Array?: ");
        string firstLength = Console.ReadLine();
        int firstArray;
        while (!int.TryParse(firstLength, out firstArray) || (firstArray < 1))
        {
            Console.Write("Please Type correct Length (number > 0): ");
            firstLength = Console.ReadLine();
        }

        char[] arrOne = new char[firstArray];

        for (int i = 0; i < firstArray; i++)
        {
            Console.Write("Position " + i + " of first array: ");

            string entrArrOne = Console.ReadLine();
            while (!char.TryParse(entrArrOne, out arrOne[i]))
            {
                Console.Write("Please type correct Char symbol: ");
                entrArrOne = Console.ReadLine();
            }
        }
        ///

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

        char[] arrTwo = new char[secondArray];

        for (int i = 0; i < secondArray; i++)
        {
            Console.Write("Position " + i + " of first array: ");

            string entrArrTwo = Console.ReadLine();
            while (!char.TryParse(entrArrTwo, out arrTwo[i]))
            {
                Console.Write("Please type correct Char symbol: ");
                entrArrTwo = Console.ReadLine();
            }
        }
        ///

        bool equal = true;

        if (arrOne.Length != arrTwo.Length)
        {
            equal = false;
            Console.WriteLine("\nThe arrays are equal: {0}", equal);
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

