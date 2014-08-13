//24. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

    class WordsInAlphabeticalOrder
    {
        static void Main()
        {
            Console.Write("Enter words separated by spaces: ");
            string[] words = Console.ReadLine().Split(' ');

            Array.Sort(words);

            Console.WriteLine();
            Console.Write("Result: ");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("\n");            
        }
    }

