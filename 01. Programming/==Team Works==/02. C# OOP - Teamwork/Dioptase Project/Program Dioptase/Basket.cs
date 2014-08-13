namespace ProgramDioptase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ProgramDioptase.Interfaces.ItemTypes;

    public static class Basket
    {
        static Basket()
        {
            RentedItems = new List<IRentable>();
            PurchasedItems = new List<ISaleable>();
        }

        public static IList<IRentable> RentedItems { get; private set; }

        public static IList<ISaleable> PurchasedItems { get; private set; }

        public static void AddRentableItem(IRentable item)
        {
            RentedItems.Add(item);
        }

        public static void AddSaleableItem(ISaleable item)
        {
            PurchasedItems.Add(item);
        }

        public static void EmptyBasket()
        {
            RentedItems.Clear();
            PurchasedItems.Clear();
        }
    }
}