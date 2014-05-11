using System;
using System.Collections.Generic;

class Anacci
{
    static void Main()
    {
        char firstDigit = char.Parse(Console.ReadLine());
        char secondDigit = char.Parse(Console.ReadLine());
        int numberOfLines = int.Parse(Console.ReadLine());

        char thirdDigit;

        List<char> allDigits = new List<char>();
        allDigits.Add(firstDigit);
        allDigits.Add(secondDigit);

        int totalDigitsCount = numberOfLines * 2 - 1;

        for (int i = 2; i < totalDigitsCount; i++)
        {
            int thirdNumber = (allDigits[i - 2] - 64) + (allDigits[i - 1] - 64);

            if (thirdNumber > 26)
            {
                while (thirdNumber >= 26)
                {
                    thirdNumber -= 26;
                }
            }

            thirdDigit = (char)(thirdNumber + 64);
            allDigits.Add(thirdDigit);
        }

        Console.WriteLine(allDigits[0]);
        int whiteSpaces = 0;

        if (totalDigitsCount > 1)
        {
            for (int i = 1; i < allDigits.Count; i += 2)
            {
                string line = String.Format("{0}{1}{2}", allDigits[i], new string(' ', whiteSpaces), allDigits[i + 1]);
                whiteSpaces++;
                Console.WriteLine(line);
            }    
        }
    }
}