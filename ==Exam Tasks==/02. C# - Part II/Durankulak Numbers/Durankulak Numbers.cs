using System;
using System.Collections.Generic;

class DurankulakNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] darankulakNumbers = new string[168];

        for (int i = 0; i < 168; i++)
        {
            if (i < 26)
            {
                darankulakNumbers[i] = ((char)('A' + i)).ToString();
            }
            else if (i < 26 * 2)
            {
                darankulakNumbers[i] = string.Format("{0}{1}", 'a', darankulakNumbers[i - 26]);
            }
            else if (i < 26 * 3)
            {
                darankulakNumbers[i] = string.Format("{0}{1}", 'b', darankulakNumbers[i - 26 * 2]);
            }
            else if (i < 26 * 4)
            {
                darankulakNumbers[i] = string.Format("{0}{1}", 'c', darankulakNumbers[i - 26 * 3]);
            }
            else if (i < 26 * 5)
            {
                darankulakNumbers[i] = string.Format("{0}{1}", 'd', darankulakNumbers[i - 26 * 4]);
            }
            else if (i < 26 * 6)
            {
                darankulakNumbers[i] = string.Format("{0}{1}", 'e', darankulakNumbers[i - 26 * 5]);
            }
            else if (i < 26 * 7)
            {
                darankulakNumbers[i] = string.Format("{0}{1}", 'f', darankulakNumbers[i - 26 * 6]);
            }
        }

        List<int> indexesOfTheInputDigit = new List<int>();

        int position = 0;
        while (position < input.Length)
        {
            if (input[position] >= 'A' && input[position] <= 'Z')
            {
                string digit = input[position].ToString();
                int index = Array.IndexOf(darankulakNumbers, digit);
                indexesOfTheInputDigit.Add(index);
                position++;
            }
            else
            {
                string digit = string.Format("{0}{1}", input[position].ToString(), input[position + 1].ToString());
                int index = Array.IndexOf(darankulakNumbers, digit);
                indexesOfTheInputDigit.Add(index);
                position += 2;
            }
        }

        ulong decimalNumber = default(int);
        int mathPower = indexesOfTheInputDigit.Count - 1;

        for (int i = 0; i < indexesOfTheInputDigit.Count; i++)
        {
            ulong calculation = (ulong)(indexesOfTheInputDigit[i] * Math.Pow(168, mathPower));
            decimalNumber += calculation;
            mathPower--;
        }

        Console.WriteLine(decimalNumber);
    }
}