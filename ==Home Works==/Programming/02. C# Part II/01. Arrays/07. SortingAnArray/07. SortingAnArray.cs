//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
//move it at the second position, etc.

using System;

class SortingAnArray
{
    static void Main()
    {
        Console.Title = "Sorting An Array";

        Console.Write("Please Enter The Count Of Numbers: ");
        string entrLenght = Console.ReadLine();
        int lenght;
        while (!int.TryParse(entrLenght, out lenght) || lenght < 1)
        {
            Console.Write("Please Type correct value (num > 0): ");
            entrLenght = Console.ReadLine();
        }

        Console.WriteLine();

        int[] arrOne = new int[lenght];

        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter Number" + (i+1) + ": ");
            string entrArrI = Console.ReadLine();
            while (!int.TryParse(entrArrI, out arrOne[i]))
            {
                Console.Write("Please Enter Correct Number: ");
                entrArrI = Console.ReadLine();
            }
        }


        int elementX = 0;

        for (int i = 0; i < lenght; i++)
        {
            for (int j = i + 1; j < lenght; j++)
            {
                if (arrOne[j] < arrOne[i])
                {
                    elementX = arrOne[i];
                    arrOne[i] = arrOne[j];
                    arrOne[j] = elementX;
                }
            }
        }

        Console.WriteLine();

        Console.Write("(");
        for (int i = 0; i < lenght; i++)
        {
            Console.Write(" " + arrOne[i]);
        }
        Console.WriteLine(" )");
        
        Console.WriteLine();
    }
}