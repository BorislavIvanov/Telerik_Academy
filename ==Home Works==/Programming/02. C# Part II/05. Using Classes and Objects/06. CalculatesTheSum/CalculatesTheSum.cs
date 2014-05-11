// 06. You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum. 
// Example: string = "43 68 9 23 318" => result = 461

using System;

class CalculatesTheSum
{
    static void Main()
    {
        Console.Write("Please enter numbers [Example: 43 68 9 23 318]: ");
        string[] numbers = Console.ReadLine().Split(' ');

        long sum = 0;

        foreach (string number in numbers)
        {
            sum += int.Parse(number);
        }

        Console.WriteLine();
        Console.WriteLine("The Sum is: {0}", sum);
        Console.WriteLine();
    }
}

