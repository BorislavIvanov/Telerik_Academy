using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Models;

namespace _10.AddStoredProcedureInNorthwind
{
    class Program
    {
        public static void Main()
        {
            var supplierName = "Exotic Liquids";
            var startDate = new DateTime(1996, 1, 1);
            var endDate = new DateTime(1997, 12, 31);

            // First input the stored procedure and after thar uncomment the code lines.
            using (var northwindEntities = new NorthwindEntities())
            {
                //var totalIncomes = northwindEntities.usp_TotalIncomesOfSupplier(supplierName, startDate, endDate).Single();

                //Console.WriteLine("Total incomes: {0:C}", totalIncomes);
            }
        }
    }
}
