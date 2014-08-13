//14. A dictionary is stored as a sequence of text lines containing words and their explanations.
//    Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"
        };

        Console.Write("Please enter a Word: ");
        string inputWord = Console.ReadLine();

        Console.WriteLine();
        foreach (string item in dictionary)
        {
            var fragments = Regex.Match(item, "(.*?) - (.*)").Groups;

            if (fragments[1].Value == inputWord)
            {
                Console.WriteLine(fragments[2]);
                Console.WriteLine();
                return;
            }
        }
    }
}

	


