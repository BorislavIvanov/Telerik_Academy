//Write a program that reads two positive integer numbers and prints how many numbers "p" exist between them
//such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class NumbersBetweenAandB
{
    static void Main()
    {
        Console.Title = "Numbers Between A and B";

        Console.WriteLine("Type numbers A and B (A < B);\n");
        Console.Write("Tupe number A: ");
        int numA = int.Parse(Console.ReadLine());
        Console.Write("Type number B: ");
        int numB = int.Parse(Console.ReadLine());

        if (numA < numB)
        {
            int count = 0;
            for (int i = numA; i <= numB; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(new string ('~', 14));
            Console.WriteLine("The number count is: {0}", count);
        }
        else
        {
            Console.WriteLine("Warning A > B!!! Enter Valid Numbers (A<B) !!! ");
        }

    }
}

