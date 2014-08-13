using System;
using System.Linq;
using ProgramDioptase.Interfaces.ItemTypes;

namespace ProgramDioptase.ItemTypes
{
    public abstract class RentableItem : CatalogItem, IRentable
    {
        public decimal PricePerDay { get; protected set; }

        public decimal TotalPrice { get; protected set; }

        public DateTime RentalDate { get; protected set; }

        public DateTime ReturnDate { get; protected set; }

        public bool IsInStock { get; protected set; }
    }
}