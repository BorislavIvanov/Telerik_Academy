//09. We are given a string containing a list of forbidden words and a text containing some of these words.
//    Write a program that replaces the forbidden words with asterisks.
using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceWordWithAsterisks
{
    static void Main()
    {
        Console.Write("Enter some Text: ");
        string inputText = Console.ReadLine();

        Console.WriteLine("Enter the Words(for separation use comma, dot, slash): ");
        string inputWords = Console.ReadLine();

        inputWords = inputWords.Trim(' ');
        string[] listOfWords = inputWords.Split(',', '/', '\\');

        for (int i = 0; i < listOfWords.Length; i++)
        {
            string oldWord = listOfWords[i];
            string newWord = new string ('*', oldWord.Length);

            inputText = Regex.Replace(inputText, oldWord, newWord, RegexOptions.IgnoreCase);
        }
        Console.WriteLine();
        Console.WriteLine(inputText);
        Console.WriteLine();
    }
}

