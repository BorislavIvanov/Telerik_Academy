using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Models;

namespace _04.FindAllOrdersFrom1997ToCanada_WhitNativeSQLQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1997;
            string country = "Canada";

            FindByOrderUsingSQL(year, country);
        }

        private static void FindByOrderUsingSQL(int year, string country)
        {
            NorthwindEntities db = new NorthwindEntities();

            string nativeSQLQuery =
                                    "SELECT c.CustomerID " +
                                    "FROM Customers c " +
                                    "JOIN Orders o " +
                                    "ON c.CustomerID = o.CustomerID " +
                                   "WHERE YEAR(o.OrderDate) = {0} " +
                                    "AND o.ShipCountry = {1} " +
                                    "group by c.CustomerID";

            object[] parameters = { year, country };

            var orders = db.Database.SqlQuery<string>(nativeSQLQuery, parameters);

            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
