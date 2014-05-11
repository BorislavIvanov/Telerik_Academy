//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class SieveOfEratosthenesAlgorithm
{
    static void Main()
    {
        List<int> num = new List<int>();

        num.Add(2);
        num.Add(3);
        num.Add(5);
        for (int i = 6; i <= 10000000; i++)
        {

            if ((i % 2 == 0) || (i % 3 == 0) || (i % 5 == 0))
            {
                continue;
            }
            else num.Add(i);
        }

        for (int i = 0; i < num.Count; i++)
        {
            if (i % 15 == 0) Console.WriteLine();
            Console.Write("{0,10}", num[i]);

        }
        Console.WriteLine();
    }
}

