//13. Write a program that reverses the words in given sentence.
//    Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;

class ReverseTheWords
{
    static void Main()
    {
        Console.WriteLine("Enter some Text: ");
        string inputText = Console.ReadLine();

        char[] puncts = new char[] { ' ', '.', '?', '!', ';', ',', ':' };
        string[] words = inputText.Split(puncts, StringSplitOptions.RemoveEmptyEntries);
        string[] revWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            revWords[i] = words[words.Length - i - 1];
        }

        Console.WriteLine();
        Console.WriteLine("Result: ");
        foreach (string word in revWords)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine("\n");
    }
}

