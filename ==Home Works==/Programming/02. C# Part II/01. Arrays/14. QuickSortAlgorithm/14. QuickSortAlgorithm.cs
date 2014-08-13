// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSortAlgorithm
{
    static void Main()
    {
        Console.Write("Please enter The Count Of Numbers: ");
        string numberCountEntr = Console.ReadLine();
        int numberCount;
        while (!int.TryParse(numberCountEntr, out numberCount) || numberCount < 1)
        {
            Console.Write("Please Enter correct Value (num > 0): ");
            numberCountEntr = Console.ReadLine();
        }

        Console.WriteLine();

        string[] arrOne = new string[numberCount];

        for (int i = 0; i < numberCount; i++)
        {
            Console.Write("Enter Element " + (i+1) + ": ");
            arrOne[i] = Console.ReadLine();
        }

        Console.WriteLine();

        // Print The unsorted array:
        Console.WriteLine("The Unsorted array: ");

        Console.Write("(");
        for (int i = 0; i < arrOne.Length; i++)
        {
            Console.Write(" " + arrOne[i]);
        }
        Console.WriteLine(" )");

        Console.WriteLine();

        //Sorting...
        Quicksort(arrOne, 0, arrOne.Length - 1);

        //Print the sorted array:
        Console.WriteLine("The Sorted array: ");

        Console.Write("(");
        for (int i = 0; i < arrOne.Length; i++)
        {
            Console.Write(" "+arrOne[i]);
        }
        Console.WriteLine(" )");

        Console.WriteLine();
    }

    public static void Quicksort(string[] arrTwo, int left, int right)
    {
        int i = left, j = right;
        string middle = arrTwo[(left + right) / 2];

        while (i <= j)
        {
            while (arrTwo[i].CompareTo(middle) < 0)
            {
                i++;
            }

            while (arrTwo[j].CompareTo(middle) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                string x = arrTwo[i];
                arrTwo[i] = arrTwo[j];
                arrTwo[j] = x;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quicksort(arrTwo, left, j);
        }

        if (i < right)
        {
            Quicksort(arrTwo, i, right);
        }
    }
}

