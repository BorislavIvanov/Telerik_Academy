//20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

class PalindromesExtract
{
    static void Main()
    {
        Console.WriteLine("Please Enter some Text: ");
        string text = Console.ReadLine();

        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] splittedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine();
        Console.WriteLine("Result: ");

        foreach (string word in splittedText)
        {
            bool isPalindrome = true;

            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }

        Console.WriteLine();
    }
}

