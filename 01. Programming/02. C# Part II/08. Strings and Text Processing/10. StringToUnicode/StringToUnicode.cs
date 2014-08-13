//10. Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

using System;

class StringToUnicode
{
    static void Main()
    {
        Console.Write("Please Enter some Text: ");
        string inputText = Console.ReadLine();

        Console.WriteLine();
        Console.Write("Result: ");
        foreach (var symbol in inputText)
        {
            Console.Write("\\u{0:X4}", (int)symbol);
        }
        Console.WriteLine("\n");
    }
}

