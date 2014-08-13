using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> collectionOfFurnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            collectionOfFurnitures = new List<IFurniture>();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Company Name is Invalid! The Value is null or whitespace or less than 5 chars!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string RegistrationNumber
        {
            get 
            { 
                return this.registrationNumber; 
            }
            private set
            {
                bool isValid = value.Length == 10 && value.All(char.IsDigit);

                if (isValid)
                {
                    this.registrationNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid RegistrationNumber!");
                }
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.collectionOfFurnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.collectionOfFurnitures.Add(furniture);
            this.collectionOfFurnitures = this.collectionOfFurnitures.OrderBy(f => f.Price).ThenBy(f => f.Model).ToList();
        }

        public void Remove(IFurniture furniture)
        {
            this.collectionOfFurnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            try
            {
                return this.collectionOfFurnitures.First(i => i.Model == model);
            }
            catch(InvalidOperationException)
            {
                return null;
            }
            
        }

        public string Catalog()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("{0} - {1} - {2} {3}",
                this.Name, this.RegistrationNumber, this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no", this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            if (this.Furnitures.Count != 0)
            {
                foreach (var item in this.Furnitures)
                {
                    output.AppendLine();
                    output.Append(item);
                }
            }

            return output.ToString();
        }
    }
}
