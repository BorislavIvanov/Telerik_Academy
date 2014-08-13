// 01. Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
//(height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at 
//initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that 
//tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.

using System;

class TestApp
{
    static void Main()
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Circle(3.29);
        shapes[1] = new Rectangle(6, 3);
        shapes[2] = new Triangle(5, 9);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result:");
        Console.WriteLine("Circle surface: {0}", shapes[0].CalculateSurface());
        Console.WriteLine("Rectangle surface {0}", shapes[1].CalculateSurface());
        Console.WriteLine("Triangle surface {0}", shapes[2].CalculateSurface());
        Console.ResetColor();

        Console.WriteLine();
    }
}

