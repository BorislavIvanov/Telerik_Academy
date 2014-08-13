//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

class BitAtPosition
{
    static void Main()
    {
        Console.Title = "Bit At Position";

        Console.Write("Type the number (v): ");
        int theNumber = int.Parse(Console.ReadLine());

        Console.Write("Type the position (p): ");
        int thePosition = int.Parse(Console.ReadLine());

        int mask = 1 << thePosition;
        int numAndMask = theNumber & mask;
        int theBit = numAndMask >> thePosition;

        bool result = (theBit == 1);

        Console.WriteLine(new string('-', 10));

        Console.Write("In Number {0} at position {1} have bit 1: ", theNumber, thePosition);
        Console.WriteLine(result);
    }
}
