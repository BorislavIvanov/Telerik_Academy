//You are given an array of strings. Write a method that sorts the array
//by the length of its elements (the number of characters composing them).

using System;

class SortsArrayByTheLength
{
    static void Main()
    {
        Console.Write("Please Enter the number of Strings: ");
        int stringsCount = int.Parse(Console.ReadLine());

        Console.WriteLine();

        string[] arrayOfStrings = new string[stringsCount];
        for (int i = 0; i < stringsCount; i++)
        {
            Console.Write("Please Enter String number " + (i + 1) + ": ");
            arrayOfStrings[i] = Console.ReadLine();
        }

        Console.WriteLine();

        int[] sizes = new int[arrayOfStrings.Length];

        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            sizes[i] = arrayOfStrings[i].Length;
        }

        Array.Sort(sizes, arrayOfStrings);

        foreach (var element in arrayOfStrings)
        {
            Console.Write(" < {0} > ", element);
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}

