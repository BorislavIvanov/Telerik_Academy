using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDB.Models;

namespace _02.CustomerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindEntities();

            using (db)
            {
                string customerID = "AAAAA";
                string companyName = "ARS";
                string contactName = "Kiril Ivanov";
                string country = "Bulgaria";

                DAO.CreateNewCustomer(db, customerID, companyName, contactName, country);

                string newCompanyName = "BBR";
                string newContactName = "Marin Ivanov";

                DAO.ModifyCustomerByID(db, customerID, newCompanyName, newContactName);

                DAO.RemoveCustomerByID(db, customerID);
            }
        }

        
    }
}
