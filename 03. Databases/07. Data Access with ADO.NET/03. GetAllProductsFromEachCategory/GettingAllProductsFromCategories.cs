using System;
using System.Data.SqlClient;

class GettingAllProductsFromCategories
{
    static void Main()
    {
        SqlConnection sqlConnect = new SqlConnection("Server=BOBBY-PC; " +
            "Database=NORTHWND; Integrated Security=true");

        sqlConnect.Open();

        using (sqlConnect)
        {
            SqlCommand cmdGetAllNamesAndDescriptions = new SqlCommand(
                "SELECT c.CategoryName, p.ProductName " + 
                "FROM NORTHWND.dbo.Categories c " + 
                "INNER JOIN NORTHWND.dbo.Products p ON c.CategoryID = p.CategoryID", sqlConnect);

            SqlDataReader reader = cmdGetAllNamesAndDescriptions.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["CategoryName"];
                    string productName = (string)reader["ProductName"];
                    Console.WriteLine("{0} - {1}", name, productName);
                }
            }
        }
    }
}