using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get 
            { 
                return this.model ;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Invalid Furniture Model! Value is null or whitespace or less than 3 chars!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Material
        {
            get 
            { 
                return this.material; 
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Furniture Material;");
                }
                else
                {
                    this.material = value;
                    this.material = char.ToUpper(this.material[0]) + this.material.Substring(1);
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Furniture Price! The price cant be less or equal to $0.00!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public decimal Height
        {
            get 
            { 
                return this.height; 
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Furniture Height! The height cant be less or equal to 0.00m!");
                }
                else
                {
                    this.height = value;
                }
            }
        }
    }
}
