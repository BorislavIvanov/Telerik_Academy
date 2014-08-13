//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;

class MaximalElement
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Enter element with index " + i + ": ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.Write("The Array: ");
        MaximalElement.ArrayPrint(array);

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Enter The Starting index: ");
        int startingIndex = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Maximal Element from The Starting index {0} is: ", startingIndex);
        Console.WriteLine(FindMaximalElementInArray(startingIndex, array));

        Console.WriteLine();

        Console.Write("Ascending Sort: ");
        MaximalElement.AscendingSort(array);
        MaximalElement.ArrayPrint(array);

        Console.WriteLine("\n");

        Console.Write("Descending Sort: ");
        MaximalElement.DescendingSort(array);
        MaximalElement.ArrayPrint(array);

        Console.WriteLine("\n");
    }

    static void ArrayPrint(int[] theArray)
    {
        foreach (int number in theArray)
        {
            Console.Write(number);
        }
    }

    static int FindMaximalElementInArray(int startingIndex, int[] array)
    {
        int maximal = array[startingIndex];
        int bestmaximal = array[startingIndex];
        for (int i = startingIndex; i < array.Length - 1; i++)
        {
            if (array[i + 1] > array[i])
            {
                maximal = array[i + 1];

                if (bestmaximal < maximal)
                {
                    bestmaximal = maximal;
                }
            }
        }
        return bestmaximal;
    }

    static int[] AscendingSort(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }

    static int[] DescendingSort(int[] array)
    {
        int temp = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            for (int j = array.Length - 1; j >= 0; j--)
            {
                if (array[i] < array[j])
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        return array;
    }
}

