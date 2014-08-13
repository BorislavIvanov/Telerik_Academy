//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Title = "Trapezoid Area";

        Console.Write("Trapezoid side \"a\" is?:  ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Trapezoid side \"b\" is?:  ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Trapezoid height is?:    ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 10));

        Console.WriteLine("Trapezoid area is: " + ((((sideA + sideB) * height) / 2)));

    }
}

