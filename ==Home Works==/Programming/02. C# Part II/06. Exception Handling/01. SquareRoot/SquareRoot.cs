// 01. Write a program that reads an integer number and calculates and prints its square root.
//     If the number is invalid or negative, print "Invalid number".
//     In all cases finally print "Good bye". Use try-catch-finally.

using System;

class SquareRoot
{
    static void ChechForNegativeNumber(double number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException("\nInvaid Number!!!");
        }
    }

    static void Main()
    {
        Console.Write("Enter One Positive Integer Number: ");

        try
        {
            double theNumber = double.Parse(Console.ReadLine());
            ChechForNegativeNumber(theNumber);
            double calculationSquareRoot = Math.Sqrt(theNumber);
            Console.WriteLine("\nResult: {0}", calculationSquareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("\nInvalid number!!!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("\nInvalid number!!!");
        }
        catch (ArgumentOutOfRangeException theExeption)
        {
            Console.WriteLine(theExeption.ParamName);
        }
        finally
        {
            Console.WriteLine("\nGood Bye!!!");
            Console.WriteLine();
        }
    }
}

