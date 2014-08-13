using System;
using System.Collections.Generic;

class KaspichanNumbers
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());

        string[] kaspichanDigits = new string[256];

        for (int i = 0; i < 256; i++)
        {
            if (i < 26)
            {
                kaspichanDigits[i] = ((char)('A' + i)).ToString();
            }
            else if (i < 26 * 2)
            {
                kaspichanDigits[i] = String.Format("{0}{1}", 'a', kaspichanDigits[i - 26]);
            }
            else if (i < 26 * 3)
            {
                kaspichanDigits[i] = String.Format("{0}{1}", 'b', kaspichanDigits[i - 26 * 2]);
            }
            else if (i < 26 * 4)
            {
                kaspichanDigits[i] = String.Format("{0}{1}", 'c', kaspichanDigits[i - 26 * 3]);
            }
            else if (i < 26 * 5)
            {
                kaspichanDigits[i] = String.Format("{0}{1}", 'd', kaspichanDigits[i - 26 * 4]);
            }
            else if (i < 26 * 6)
            {
                kaspichanDigits[i] = String.Format("{0}{1}", 'e', kaspichanDigits[i - 26 * 5]);
            }
            else if (i < 26 * 7)
            {
                kaspichanDigits[i] = String.Format("{0}{1}", 'f', kaspichanDigits[i - 26 * 6]);
            }
            else if (i < 26 * 8)
            {
                kaspichanDigits[i] = String.Format("{0}{1}", 'g', kaspichanDigits[i - 26 * 7]);
            }
            else if (i < 26 * 9)
            {
                kaspichanDigits[i] = String.Format("{0}{1}", 'h', kaspichanDigits[i - 26 * 8]);
            }
            else if (i < 26 * 10)
            {
                kaspichanDigits[i] = String.Format("{0}{1}", 'i', kaspichanDigits[i - 26 * 9]);
            }
        }

        if (input == 0)
        {
            Console.WriteLine("A");
        }
        else
        {
            List<ulong> buffer = new List<ulong>();

            while (input != 0)
            {
                buffer.Add(input % 256);
                input = input / 256;
            }

            for (int i = buffer.Count - 1; i >= 0; i--)
            {
                Console.Write(kaspichanDigits[buffer[i]]);
            }
        }
    }
}

