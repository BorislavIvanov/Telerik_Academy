// 02. Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//     If an invalid number or non-number text is entered, the method should throw an exception.
//     Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class TenNumbers
{
    static void ChechForNumberInRange(int inputNumber)
    {
        if (inputNumber < 1 && 100 > inputNumber)
        {
            throw new ArgumentOutOfRangeException("Number is Out of range (min 1, max 100)");
        }
    }
    static void ReadNumber(int start, int end)
    {
        Console.Write("Enter number in range from {0} to {1}: ", start, end);

        try
        {
            int inputNumber = int.Parse(Console.ReadLine());
            ChechForNumberInRange(inputNumber);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error!!! Invalid input value!!!");
        }
        catch (ArgumentOutOfRangeException theException)
        {
            Console.WriteLine(theException.ParamName);
        }
    }

    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            ReadNumber(1, 100);
            Console.WriteLine();
        }
    }
}

