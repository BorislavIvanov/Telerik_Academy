// 02. Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class TenRandomValues
{
    private static Random randomGenerator = new Random();

    static void Main()
    {
        Console.WriteLine("Ten random numbers from 100 to 200:");

        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Random Number " + (i + 1) + ": " + randomGenerator.Next(100, 201));
        }

        Console.WriteLine();
    }
}

