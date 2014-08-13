//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

class BitValue
{
    static void Main()
    {
        Console.Title = "Bit Value";

        Console.Write("Type the number (i): ");
        int theNumber = int.Parse(Console.ReadLine());

        Console.Write("Type the bit number (b): ");
        int thePosition = int.Parse(Console.ReadLine());

        int mask = 1 << thePosition;
        int numAndMask = theNumber & mask;
        int theBit = numAndMask >> thePosition;

        Console.WriteLine(new string('-',10));

        Console.Write("The BitValue in number {0} at position {1} is: ",theNumber, thePosition);
        Console.WriteLine(theBit);
    }
}

