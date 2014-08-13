//05.Write a method that checks if the element at given position in given array of integers
//is bigger than its two neighbors (when such exist).

using System;

class ElementCheck
{
    static void ElementPosition(int thePosition, int[] theArray)
    {
        if (thePosition == 0)
        {
            ElementCheck.CompareRightSide(theArray);
        }
        else if (thePosition == (theArray.Length - 1))
        {
            ElementCheck.CompareLeftSide(theArray);
        }
        else
        {
            ElementCheck.CompareTwoSides(thePosition, theArray);
        }
    }
    static void CompareRightSide(int[] theArray)
    {
        if (theArray[0] > theArray[1])
        {
            Console.WriteLine("The element at the position is bigger than its Right neighbor.");
        }
        else
        {
            Console.WriteLine("The element at the position is not bigger than its Right neighbor.");
        }
    }

    static void CompareLeftSide(int[] theArray)
    {
        
        if (theArray[theArray.Length - 1] > theArray[theArray.Length - 2])
        {
            Console.WriteLine("The element at the position is bigger than its Left neighbor.");
        }
        else
        {
            Console.WriteLine("The element at the position is not bigger than its Left neighbor.");
        }
        
    }

    static void CompareTwoSides(int thePosition, int[] theArray)
    {
        if (theArray[thePosition - 1] + theArray[thePosition + 1] < theArray[thePosition])
        {
            Console.WriteLine("The element at the position is bigger than its two neighbors.");
        }
        else
        {
            Console.WriteLine("The element at the position is not bigger than its two neighbors.");
        }
    }

    static void Main()
    {
        Console.Write("Enter Length of the array: ");
        int arrLength = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int[] array = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("Enter the number with index " + i + ": ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Console.Write("Enter the Position of given element (From 0 to {0}): ",arrLength-1);
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine();

        ElementCheck.ElementPosition(position, array);

        Console.WriteLine();
    }
}

