//Write a method that returns the index of the first element in array that is bigger than its neighbors,
//or -1, if there’s no such element.

using System;

class IndexOfTheFirstBiggerElement
{
    static int ElementPosition(int thePosition, int[] theArray)
    {
        int answer;
        if (thePosition == 0)
        {
            answer = IndexOfTheFirstBiggerElement.CompareRightSide(theArray);
        }
        else if (thePosition == (theArray.Length - 1))
        {
            answer = IndexOfTheFirstBiggerElement.CompareLeftSide(theArray);
        }
        else
        {
            answer = IndexOfTheFirstBiggerElement.CompareTwoSides(thePosition, theArray);
        }
        return answer;
    }
    static int CompareRightSide(int[] theArray)
    {
        int answer;
        if (theArray[0] > theArray[1])
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
        return answer;
    }

    static int CompareLeftSide(int[] theArray)
    {
        int answer;
        if (theArray[theArray.Length - 1] > theArray[theArray.Length - 2])
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
        return answer;
    }

    static int CompareTwoSides(int thePosition, int[] theArray)
    {
        int answer;
        if (theArray[thePosition - 1] + theArray[thePosition + 1] < theArray[thePosition])
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
        return answer;
    }

    static int LinearFindingLoop(int[] array)
    {
        int index = -1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            int answer = IndexOfTheFirstBiggerElement.ElementPosition(i, array);

            if (answer == 1)
            {
                index = i;
                break;
            }
            else
            {
                continue;
            }
        }
        return index;
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

        Console.WriteLine("Index (-1 if not found): " + IndexOfTheFirstBiggerElement.LinearFindingLoop(array));

        Console.WriteLine();
    }
}

