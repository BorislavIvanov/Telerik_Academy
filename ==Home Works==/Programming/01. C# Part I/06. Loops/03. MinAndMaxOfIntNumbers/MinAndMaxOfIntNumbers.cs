//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxOfIntNumbers
{
    static void Main()
    {
        Console.Title = "Min And Max Of Int Numbers";

        
        int theNumber;
        int maxNumber = int.MinValue;
        int minNumber = int.MaxValue;

        Console.Write("Enter how many numbers you want: ");
        string countInput = Console.ReadLine();
        int countN;
        while (!int.TryParse(countInput, out countN) || countN < 1)
        {
            Console.Write("Enter Valid Count (the Count > 0): ");
            countInput = Console.ReadLine();
        }

        Console.WriteLine(new string ('-', 32));

        for (int i = 1; i <= countN; i++)
        {

            Console.Write("\nPlease Enter Number {0}: ", i);
            string numberInput = Console.ReadLine();
            while (!int.TryParse(numberInput, out theNumber))
            {
                Console.Write("Enter Valid Number!!!: ");
                numberInput = Console.ReadLine();
            }
            
            if (theNumber > maxNumber)
            {
                maxNumber = theNumber;
            }

            if (theNumber < minNumber)
            {
                minNumber = theNumber;
            }
        }

        Console.WriteLine(new string('-', 32));

        Console.WriteLine("\nMin: {0}; Max: {1};\n", minNumber, maxNumber);
    }
}

