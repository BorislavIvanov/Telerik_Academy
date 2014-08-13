//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class TheIndexOfEachLetter
{
    static void Main()
    {
        //"...print the index of each of its letters in the array." - za tova v programata mi (A = 0) a ne na 1 :)

        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZA".ToCharArray();

        Console.Write("Please enter one word: ");
        string word = (Console.ReadLine().ToUpper());

        Console.WriteLine();

        Console.WriteLine("Result:");

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine("Letter {0} have index {1}", word[i], word[i] - 'A');
        }

        Console.WriteLine();
    }
}

