using System;

class Rectangle : Shape
{
    // Constructor
    public Rectangle(double width, double height) : base(width, height)
    {
    }

    // Method
    public override double CalculateSurface()
    {
        double calculation = this.Height * this.Width;

        return calculation;
    }
}