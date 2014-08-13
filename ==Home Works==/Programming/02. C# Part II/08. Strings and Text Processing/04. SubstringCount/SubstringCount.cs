//04. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;
using System.Text.RegularExpressions;

class SubstringCount
{
    static void Main()
    {
        Console.Write("Type a text: ");
        string inputText = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Type the Substring: ");
        string pattern = Console.ReadLine();

        Console.WriteLine();

        int matches = Regex.Matches(inputText, pattern).Count;

        Console.Write("Result: {0}", matches);
        Console.WriteLine("\n");
    }
}
