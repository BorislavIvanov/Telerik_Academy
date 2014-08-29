using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Models;

namespace _05.AllSalesByPeriod
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindEntities();

            string orderRegion = null;
            int startOrderYear = 1996;
            int endOrderYear = 1996;

            using (db)
            {
                ShowAllSalesByGivenRegionAndDate(db, orderRegion, startOrderYear, endOrderYear);
            }
        }

        private static void ShowAllSalesByGivenRegionAndDate(NorthwindEntities db, string orderRegion, int startOrderYear, int endOrderYear)
        {
            var allOrders =
                from order in db.Orders
                where order.ShipRegion == orderRegion &&
                order.ShippedDate.Value.Year >= startOrderYear &&
                order.ShippedDate.Value.Year <= endOrderYear
                select order;

            foreach (var order in allOrders)
            {
                Console.WriteLine("OrderID " + order.OrderID +
                    "; ShipRegion: " + order.ShipRegion +
                    "; ShipDate: " + order.ShippedDate);
            }
        }
    }
}
