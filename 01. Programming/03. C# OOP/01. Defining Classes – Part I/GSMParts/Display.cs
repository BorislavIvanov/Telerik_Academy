using System;

namespace GSMProgram
{
    public class Display// Task 1
    {
        private decimal? diagonalSize;// Task 1
        private int? numberOfColors;// Task 1

        public Display() : this(null, null)// Task 2
        {
        }
        public Display (decimal? diagonalSize) : this(diagonalSize, null)
        {
        }
        public Display (decimal? diagonalSize, int? numberOfColors)
        {
            this.DiagonalSize = diagonalSize;
            this.NumberOfColors = numberOfColors;
        }

        public decimal? DiagonalSize// Task 5
        {
            get
            {
                return this.diagonalSize;
            }
            set
            {
                if (value == null || (value > 0 && value < decimal.MaxValue))
                {
                    this.diagonalSize = value;
                }
                else
                {
                    throw new ArgumentException("The DiagonalSize is Out of range!");
                }
            }
        }

        public int? NumberOfColors// Task 5
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value == null || (value > 0 && value < int.MaxValue))
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException("The NumberOfColors is Out of range");
                }
            }
        }
    }
}