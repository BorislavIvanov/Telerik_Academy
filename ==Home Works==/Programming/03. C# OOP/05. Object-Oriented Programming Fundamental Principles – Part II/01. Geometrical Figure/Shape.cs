using System;

    abstract class Shape
    {
        private double width;
        private double height;

        // Methods
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive positive value and more than 0!!!");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be positive positive value and more than 0!!!");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        // Constructors
        public Shape(double radius)
        {
            this.Width = radius;
        }
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Method
        public abstract double CalculateSurface();
    }

