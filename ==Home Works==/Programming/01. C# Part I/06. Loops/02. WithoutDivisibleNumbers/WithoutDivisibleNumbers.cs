//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class WithoutDivisibleNumbers
{
    static void Main()
    {
        Console.Title = "Without Divisible Numbers";

        Console.Write("Please enter The N (N > 1): ");
        string consoleInput = Console.ReadLine();

        int numberN;

        while (!int.TryParse(consoleInput, out numberN) || (numberN < 1))
        {
            Console.Write("Please enter Valid N number!!!(from 1 to 2,147,483,647): ");
            consoleInput = Console.ReadLine();
        }

        Console.WriteLine(new string('~', 27));
        Console.WriteLine("All Numbers From 1 to {0} without divisible numbers by 3 and 7 at the same time:", numberN);

        for (int i = 1; i <= numberN; i++)
        {
            while (!(i % 21 == 0))
            {
                Console.WriteLine("\n{0}", i);
                break;
            }
        }

    }
}

