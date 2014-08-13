//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointInCircle
{
    static void Main()
    {
        Console.Title = "Point In Circle";

        double radius = 5;

        Console.Write("Type Value X: ");
        double valueX = double.Parse(Console.ReadLine());

        Console.Write("Type Value Y: ");
        double valueY = double.Parse(Console.ReadLine());

        double theCalculation = (valueX * valueX) + (valueY * valueY); //Pythagorean theorem.

        if (theCalculation <= radius * 2)
        {
            Console.WriteLine("The point is in the circle!");
        }
        else
        {
            Console.WriteLine("The point is out of the circle!");
        }
    }
}

