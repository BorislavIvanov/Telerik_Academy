//11. Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

using System;

class RepresentationOfNumber
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Result: ");
        Console.WriteLine("{0,15:D}", inputNumber);
        Console.WriteLine("{0,15:X}", inputNumber);
        Console.WriteLine("{0,15:P}", inputNumber);
        Console.WriteLine("{0,15:E}", inputNumber);
        Console.WriteLine();
    }
}

