//22. Write a program that reads a string from the console and lists all different words in the string along with information
//    how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text;

class WordCounter
{
    static void Main()
    {
        Console.Write("Please enter some Text: ");
        string inputText = Console.ReadLine();

        Console.WriteLine();

        Dictionary<string, int> Words = new Dictionary<string, int>();
        var letters = new StringBuilder();
        foreach (var item in inputText.ToLower())
        {
            if (Char.IsLetter(item))
            {
                letters.Append(item);
            }
            else if (letters.Length > 0)
            {
                if (Words.ContainsKey(letters.ToString()))
                {
                    Words[letters.ToString()]++;
                }
                else
                {
                    Words.Add(letters.ToString(), 1);
                }
                letters.Clear();
            }
        }

        Console.WriteLine("Result: ");
        foreach (var item in Words)
        {
            Console.WriteLine("{0} - {1} times found", item.Key, item.Value);
        }

        Console.WriteLine();
    }
}

