//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.Title = "Perimeter And Area Of Circle";

        Console.Write("Type the circle radius: ");
        double radius = double.Parse(Console.ReadLine());

        double diameter = radius + radius;
        double perimeter = Math.PI * diameter;
        double area = (Math.PI * (radius * radius));

        Console.WriteLine(new string('-', 15));

        Console.WriteLine("The Perimeter of Circle is : {0}", perimeter);
        Console.WriteLine("The Area of Circle is: {0}", area);
    }
}

