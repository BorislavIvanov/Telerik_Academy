using NorthwindDB.Models;
using System.Linq;

namespace _02.CustomerOperations
{
    public class DAO
    {
        public static void ModifyCustomerByID(NorthwindEntities db, string customerID, string newCompanyName, string newContactName)
        {
            var customerForUpdate = db.Customers.Where(c => c.CustomerID == customerID).First();

            customerForUpdate.CompanyName = newCompanyName;
            customerForUpdate.ContactName = newContactName;

            db.SaveChanges();
        }

        public static void RemoveCustomerByID(NorthwindEntities db, string customerID)
        {
            var customerForRemove = db.Customers.Where(c => c.CustomerID == customerID).First();

            db.Customers.Remove(customerForRemove);
            db.SaveChanges();
        }

        public static void CreateNewCustomer(NorthwindEntities db, string customerID, string companyName, string contactName, string country)
        {
            var newCustomer = new Customer()
            {
                CustomerID = customerID,
                CompanyName = companyName,
                ContactName = contactName,
                Country = country
            };

            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }
    }
}
