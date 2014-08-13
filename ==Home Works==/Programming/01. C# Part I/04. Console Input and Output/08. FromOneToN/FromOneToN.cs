//Write a program that reads an integer number n from the console and
//prints all the numbers in the interval [1..n], each on a single line.

using System;

class FromOneToN
{
    static void Main()
    {
        Console.Title = "From One To N";

        Console.Write("Type the number for N: ");
        int numberN = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numberN; i++)
        {
            Console.WriteLine(i);
        }
    }
}

