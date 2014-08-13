//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Title = "Odd Or Even";

        Console.Write("Type value (from -128 to 127): ");
        sbyte theValue = sbyte.Parse(Console.ReadLine());

        if (theValue % 2 == 0)
        {
            Console.WriteLine("The value is Even.");
        }
        else
        {
            Console.WriteLine("The value is Odd");
        }
      
    }
}

