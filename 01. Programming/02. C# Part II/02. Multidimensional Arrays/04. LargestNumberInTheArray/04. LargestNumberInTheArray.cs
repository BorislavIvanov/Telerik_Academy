//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class LargestNumberInTheArray
{
    static void Main()
    {
        //Test:
        //int[] array = { 5, 0, 3, 2, 3, 6, 9, 7 };
        //int K = 7;

        Console.Write("Type The Lenght of the array: ");
        int arrayLenght = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            Console.Write("Type Number " + (i + 1) + ": ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.Write("Enter number K: ");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Array.Sort(array);

        int searchedNumber = Array.BinarySearch(array, K);
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine();

        if (searchedNumber < -1)
        {
            Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[~searchedNumber - 1]);
        }
        else if (~searchedNumber == 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[searchedNumber]);
        }

        Console.WriteLine();
    }
}

