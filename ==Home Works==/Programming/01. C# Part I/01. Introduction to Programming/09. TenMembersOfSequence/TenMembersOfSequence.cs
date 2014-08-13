//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class TenMembersOfSequence
{
    static void Main()
    {
        byte counter = 10;

        int startNumber = 2;

        for (int i = startNumber; i < startNumber + counter; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(-i + ", ");
            }
        }
        Console.ReadLine();
    }
}
    
