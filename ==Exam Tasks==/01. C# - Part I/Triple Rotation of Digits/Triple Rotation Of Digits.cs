using System;
using System.Collections.Generic;

class TripleRotationOfDigits
{
    static void Main()
    {
        string value = Console.ReadLine();
        List<char> k = new List<char>();

        foreach (char item in value)
        {
            k.Add(item);
        }

        for (int i = 0; i < 3; i++)
        {
            char lastSymbol = k[k.Count - 1];
            k.RemoveAt(k.Count - 1);
            k.Insert(0, lastSymbol);

            if (k[0] == '0')
            {
                k.RemoveAt(0);
            }
        }

        string finalString = new string(k.ToArray());
        Console.WriteLine(int.Parse(finalString));
    }
}