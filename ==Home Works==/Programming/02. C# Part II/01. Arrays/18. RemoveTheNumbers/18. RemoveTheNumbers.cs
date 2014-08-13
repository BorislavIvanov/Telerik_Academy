// * Write a program that reads an array of integers and removes from it a minimal number of elements
//in such way that the remaining array is sorted in increasing order. Print the remaining sorted array.
//Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

using System;
using System.Text;
using System.Collections.Generic;

class RemoveTheNumbers
{
    static void Main()
    {
        Console.Write("Please Type The Count of Number: ");

        int n = int.Parse(Console.ReadLine());
        List<int> arr = new List<int>();

        int count = 0;
        int startIndex = 0;

        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Please Type Number " + (i+1) + ": ");
            arr.Add(int.Parse(Console.ReadLine()));
        }


        for (int i = 0; i < arr.Count; i++)
        {
            int tempCount = 0;

            for (int j = i + 1; j < arr.Count - 1; j++)
            {
                if (arr[j] > arr[i])
                {
                    tempCount++;

                    if (tempCount > count)
                    {
                        count = tempCount;
                        startIndex = i;
                    }
                }
            }
        }

        arr.RemoveRange(0, startIndex);

        int tempLenght = arr.Count;

        for (int i = 1; i < tempLenght; i++)
        {
            if (arr[i] <= arr[i - 1])
            {
                arr.RemoveAt(i);
                tempLenght--;
                i--;
            }
        }

        Console.WriteLine();

        Console.Write("Searched array is:");
        for (int i = 0; i < arr.Count; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }
}

