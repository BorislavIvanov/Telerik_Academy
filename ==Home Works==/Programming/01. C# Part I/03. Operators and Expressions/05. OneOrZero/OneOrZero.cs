//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class OneOrZero
{
    static void Main()
    {
        Console.Title = "One Or Zero";

        Console.Write("Type a number: ");
        int theNum = int.Parse(Console.ReadLine());
        int position = 3;

        int mask = 1 << position;
        int numAndMask = theNum & mask;
        int theBit = numAndMask >> position;

        Console.WriteLine("The bit in position 3 is: " + theBit);
    }
}

