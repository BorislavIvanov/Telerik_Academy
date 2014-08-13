//21. Write a program that reads a string from the console and prints all different letters in the string along with information
//    how many times each letter is found. 

using System;
using System.Collections.Generic;

class LetterCounter
{
    static void Main()
    {
        Console.Write("Enter Some Text: ");

        string inputText = Console.ReadLine();

        Dictionary<char, int> Letters = new Dictionary<char, int>();

        foreach (var item in inputText.ToLower())
        {
            if (Char.IsLetter(item))
            {
                if (Letters.ContainsKey(item))
                {
                    Letters[item]++;
                }
                else
                {
                    Letters.Add(item, 1);
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Result: ");

        foreach (var letter in Letters)
        {
            Console.WriteLine("{0} - {1} times found", letter.Key, letter.Value);
        }

        Console.WriteLine();
    }
}

