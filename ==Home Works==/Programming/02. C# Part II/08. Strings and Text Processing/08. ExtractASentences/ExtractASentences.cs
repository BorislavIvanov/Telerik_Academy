//08. Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractASentences
{
    static void Main()
    {
        Console.Write("Please Enter a Text: ");
        string inputText = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Enter The Word: ");
        string inputWord = Console.ReadLine();

        string[] sentences = inputText.Split('.');

        Console.WriteLine();
        Console.WriteLine("Result: ");

        for (int i = 0; i < sentences.Length; i++)
        {
            if (Regex.Matches(sentences[i], @"\b" + inputWord + @"\b\.?", RegexOptions.IgnoreCase).Count>0)
            {
                Console.WriteLine((sentences[i] + ".").Trim());
            }
        }
        Console.WriteLine();
    }
}


