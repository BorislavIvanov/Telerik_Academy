//02.Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMax
{
    static double GetMaxCalculation(double numberX, double numberY)
    {
        double theMax = numberX;
        if (numberX < numberY)
        {
            theMax = numberY;
        }

        return theMax;
    }
    static void Main()
    {
        Console.Write("Enter number One: ");
        double numberOne = double.Parse(Console.ReadLine());

        Console.Write("Enter number Two: ");
        double numberTwo = double.Parse(Console.ReadLine());

        Console.Write("Enter number Three: ");
        double numberThree = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("The Biggest Number is: " + GetMaxCalculation(GetMaxCalculation(numberOne, numberTwo), numberThree));

        Console.WriteLine();
    }
}

