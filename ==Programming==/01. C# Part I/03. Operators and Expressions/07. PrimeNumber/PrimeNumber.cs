//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Title = "Prime Number";

        Console.Write("Type the number (from 0 to 100): ");
        byte number = byte.Parse(Console.ReadLine());

        Console.WriteLine(new string ('-', 10));

        if ((number == 2 || number == 3 || number == 5 || number == 7) || 
           (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0))
        {
            Console.WriteLine("{0} is Prime", number);
        }
        else
        {
            Console.WriteLine("{0} is NOT Prime", number);
        }
    }
}

