//Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.Title = "Rectangle Area";

        Console.Write("Rectangle width is?:  ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Rectangle height is?: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine(new string ('-', 10));

        Console.WriteLine("Rectangle area is: " + (width * height));
    }
}

