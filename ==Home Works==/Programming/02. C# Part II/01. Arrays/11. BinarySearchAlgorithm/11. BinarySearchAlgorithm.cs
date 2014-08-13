//Write a program that finds the index of given element in a sorted array of integers
//by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearchAlgorithm
{
    static void Main()
    {
        Console.Title = "Binary Search Algorithm";

        //Reshenieto izglejda dulgo zaradi whodnite danni i proverkite
        //kum tqh no sushtnostta na zadachata e v posledniqt "for" cikul :)

        Console.Write("Enter the Array Lenght: ");
        string entrLenght = Console.ReadLine();
        int lenght;
        while (!int.TryParse(entrLenght, out lenght) || lenght < 1)
        {
            Console.Write("Please Enter correct value (lenght > 0): ");
            entrLenght = Console.ReadLine();
        }

        Console.WriteLine();

        int[] arr = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter element " + (i+1) + ": ");
            string entrArrI = Console.ReadLine();
            while (!int.TryParse(entrArrI, out arr[i]))
            {
                Console.Write("Enter Correct Value: ");
                entrArrI = Console.ReadLine();
            }
        }

        Console.WriteLine();

        Array.Sort(arr);

        Console.Write("Sorted array: ");

        foreach (int array in arr)
        {
            Console.Write(array);
            Console.Write(' ');
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Please enter the number who you want to know");
        Console.Write("(The number must be from numbers in Array): ");
        string entrNumber = Console.ReadLine();
        int number;
        while (!int.TryParse(entrNumber, out number))
        {
            Console.Write("Please Enter Correct Value: ");
            entrNumber = Console.ReadLine();
        }

        Console.WriteLine();

        for (int l = 0, r = arr.Length - 1; l <= r; )
        {
            int index = l + (r - l) / 2;

            if (arr[index] < number) l = index + 1;
            else if (arr[index] > number) r = index - 1;
            else
            {
                Console.WriteLine("Number " + number + " is whit index: " + index);
                return;
            }
        }

        Console.WriteLine();
    }
}

