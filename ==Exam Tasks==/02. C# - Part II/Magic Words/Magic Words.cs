using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int countOfTheWords = int.Parse(Console.ReadLine());

        List<string> inputWords = new List<string>();

        for (int i = 0; i < countOfTheWords; i++)
        {
            inputWords.Add(Console.ReadLine());
        }

        int count = inputWords.Count;

        for (int j = 0; j < count; j++)
        {
            int theNewPosition = inputWords[j].Length % (countOfTheWords + 1);

            string word = inputWords[j];

            inputWords[j] = null;
            inputWords.Insert(theNewPosition, word);
            inputWords.Remove(null);
        }

        StringBuilder finalResult = new StringBuilder();

        int bigestWordLenght = int.MinValue;
        for (int l = 0; l < inputWords.Count; l++)
        {
            int a = inputWords[l].Length;
            if (a > bigestWordLenght)
            {
                bigestWordLenght = a;
            }
        }

        int usedDigit = 0;
        int usedWord = 0;

        while (usedDigit < bigestWordLenght)
        {
            string word = inputWords[usedWord];
            if (usedDigit <= word.Length - 1)
            {
                finalResult.Append(word[usedDigit]);
            }

            usedWord++;

            if (usedWord > inputWords.Count - 1)
            {
                usedDigit++;
            }

            if (usedWord > inputWords.Count - 1)
            {
                usedWord = 0;
            }
        }

        Console.WriteLine(finalResult);
    }
}