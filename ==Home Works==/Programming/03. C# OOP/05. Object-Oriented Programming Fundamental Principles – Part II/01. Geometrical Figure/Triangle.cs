using System;

class Triangle : Shape
{
    // Constructor
    public Triangle(double width, double height) : base(width, height)
    {
    }

    // Method
    public override double CalculateSurface()
    {
        double calculation = (this.Height * this.Width) / 2;

        return calculation;
    }
}

