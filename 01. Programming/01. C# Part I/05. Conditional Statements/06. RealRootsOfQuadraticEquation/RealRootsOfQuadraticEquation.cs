//Write a program that enters the coefficients a, b and c of a quadratic equation
//a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

class RealRootsOfQuadraticEquation
{
    static void Main()
    {
        Console.Title = "Quadratic Equation";

        Console.Write("Type coefficient A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Type coefficient B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Type coefficient C: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("This is not an quadratic equation!");
        }
        else
        {
            double discriminant = (b * b) - (4 * a * c);
            if (discriminant > 0)
            {
                double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The equation roots are:\nX1: {0}\nX2: {1}", x1, x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equaltion has only one root: {0}", x);
            }
            else if (discriminant < 0)
            {
                Console.WriteLine("This equations doesn't have solution!");
            }
        }
    }
}

