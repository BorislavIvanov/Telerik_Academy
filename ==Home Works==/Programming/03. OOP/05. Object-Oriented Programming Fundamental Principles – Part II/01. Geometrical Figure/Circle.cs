using System;

class Circle : Shape
{
    // Constructor
    public Circle(double radius) : base(radius)
    {
    }

    // Method
    public override double CalculateSurface()
    {
        double calculation = Math.PI * Math.Pow(this.Width, 2);

        return calculation;
    }
}