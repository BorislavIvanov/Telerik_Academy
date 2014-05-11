using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted;
        private decimal normalHeight;
        private decimal convertedHeight = 0.10m;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.IsConverted = false;
            this.NormalHeight = height;
        }

        private decimal NormalHeight
        {
            get
            {
                return this.normalHeight;
            }
            set
            {
                this.normalHeight = value;
            }
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
            private set { this.isConverted = value; }
        }

        public void Convert()
        {
            if (isConverted)
            {
                this.isConverted = false;
                this.Height = this.NormalHeight;
            }
            else
            {
                this.isConverted = true;
                this.Height = this.convertedHeight;
            }
        }

        public override string ToString()
        {
            string output = string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");

            return output;
        }
    }
}
