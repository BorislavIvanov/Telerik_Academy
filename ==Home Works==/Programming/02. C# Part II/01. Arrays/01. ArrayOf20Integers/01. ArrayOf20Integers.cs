//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class ArrayOf20Integers
{
    static void Main()
    {
        Console.Title = "Array Of 20 Integers";

        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 5;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("In place {0} is {1}",i ,numbers[i]);
        }
    }
}

