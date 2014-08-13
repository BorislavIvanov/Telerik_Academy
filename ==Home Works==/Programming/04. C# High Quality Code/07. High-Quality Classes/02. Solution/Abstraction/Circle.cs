using System;

namespace Abstraction
{
    public class Circle : Figure
    {
        private double radius;
        
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value > 0)
                {
                    this.radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Radius value can't be zero or negative!");
                }
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.radius * this.radius;
            return surface;
        }
    }
}
