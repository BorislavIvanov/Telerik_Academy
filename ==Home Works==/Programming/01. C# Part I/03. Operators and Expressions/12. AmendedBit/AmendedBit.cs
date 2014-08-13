//We are given integer number n, value v (v=0 or 1) and a position p.
//Write a sequence of operators that modifies n to hold the value v
//at the position p from the binary representation of n.
//    Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//    n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class AmendedBit
{
    static void Main()
    {
        Console.Title = "Amended Bit";

        Console.Write("Type the number (n): ");
        int theNumber = int.Parse(Console.ReadLine());

        Console.Write("Type the position (p): ");
        int thePosition = int.Parse(Console.ReadLine());

        Console.Write("Type the number for correction (v) (1 or 0): ");
        int correctWith = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 10));
        
        int mask = 1 << thePosition;

        if (correctWith == 1)
        {
            theNumber = theNumber | mask;
            Console.Write("The new value of the number (n) is: ");
            Console.WriteLine(Convert.ToString(theNumber));
        }
        else if (correctWith == 0)
        {
            theNumber = theNumber & (~mask);
            Console.Write("The new value of the number (n) is: ");
            Console.WriteLine(Convert.ToString(theNumber));
        }
        else
        {
            Console.WriteLine("The number for correction must be 1 or 0!");
        }


     }
}

