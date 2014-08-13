//Sort 3 real values in descending order using nested if statements.

using System;

class ValuesInDescendingOrder
{
    static void Main()
    {
        Console.Title = "Values In Descending Order";

        Console.Write("Type the First Number:  ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Type the Second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Type the Third Number:  ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("\n{0} {1} {2}\n", firstNumber, secondNumber, thirdNumber);
            }

            else
            {
                Console.WriteLine("\n{0} {1} {2}\n", firstNumber, thirdNumber, secondNumber);
            }
        }

        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("\n{0} {1} {2}\n", secondNumber, firstNumber, thirdNumber);
            }

            else
            {
                Console.WriteLine("\n{0} {1} {2}\n", secondNumber, thirdNumber, firstNumber);
            }
        }

        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("\n{0} {1} {2}\n", thirdNumber, firstNumber, secondNumber);
            }

            else
            {
                Console.WriteLine("\n{0} {1} {2}\n", thirdNumber, secondNumber, firstNumber);
            }
        }
    }
}

