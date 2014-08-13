//Write a program that finds the biggest of three integers using nested if statements.

using System;

class TheBiggestOfThree
{
    static void Main()
    {
        Console.Title = "The Biggest Of Three";

        Console.Write("Type the First Number:  ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Type the Second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Type the Third Number:  ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("\nThe First Number ({0}) is The Biggest!\n", firstNumber);
        }

        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("\nThe Second Number ({0}) is The Biggest!\n", secondNumber);
        }

        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("\nThe Third Number ({0}) is The Biggest!\n", thirdNumber);
        }
    }
}

