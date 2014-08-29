using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Models;

namespace _03.FindAllOrdersFrom1997ToCanada
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindEntities();

            int shipingYear = 1997;
            string shipingCountry = "Canada";

            using (db)
            {
                var allOrdersFrom1997 = GetAllOrdersByYearAndCountry(db, shipingYear, shipingCountry);

                foreach (var order in allOrdersFrom1997)
                {
                    Console.WriteLine("CustomerID: " + order.CustomerID + 
                        "; OrderID: " + order.OrderID + 
                        "; Year: " + order.OrderDate.Value.Year);
                }
            }
        }

        private static IQueryable<Order> GetAllOrdersByYearAndCountry(NorthwindEntities db, int shipingYear, string shipingCountry)
        {
            var allOrdersFrom1997 =
                from order in db.Orders
                where order.OrderDate.Value.Year == shipingYear &&
                      order.ShipCountry == shipingCountry
                select order;
            return allOrdersFrom1997;
        }
    }
}
