//23. Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//    Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Text;

class FixTheWord
{
    static void Main()
    {
        Console.Write("Enter a text(example: aaaaabbbbbcdddeeeedssaa):");
        string inputText = Console.ReadLine();

        StringBuilder remakedString = new StringBuilder();
        remakedString.Append(inputText);

        for (int i = 0, index = 0; i < remakedString.Length - 1; i++, index++)
        {
            char currentLatter = remakedString[i];
            while (index < remakedString.Length - 1 && currentLatter == remakedString[index + 1])
            {
                remakedString.Remove(index + 1, 1);
            }
        }
        Console.WriteLine();
        Console.Write("Result: ");
        Console.WriteLine(remakedString);
        Console.WriteLine();
    }
}

