//Write a program that safely compares floating-point numbers with precision of 0.000001.
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

class CompareNumbers
{
    static void Main()
    {

        Console.Title = "CompareNumbers";

        Console.Write("Enter first number: "); //Use "," not "."
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: "); //Use "," not "."
        float secondNumber = float.Parse(Console.ReadLine());

        if (firstNumber == secondNumber)
        {
            Console.WriteLine("The numbers are equal.");
        }
        else
        {
            Console.WriteLine("The numbers are not equal.");
        }
    }
}

