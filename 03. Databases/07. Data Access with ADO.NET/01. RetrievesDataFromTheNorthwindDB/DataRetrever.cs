using System;
using System.Data.SqlClient;

class DataRetrever
{
    static void Main()
    {
        SqlConnection sqlConnect = new SqlConnection("Server=BOBBY-PC; " +
            "Database=NORTHWND; Integrated Security=true");

        sqlConnect.Open();

        using (sqlConnect)
        {
            SqlCommand cmdCountOfCategories = new SqlCommand(
                "SELECT COUNT(*) FROM Categories", sqlConnect);

            int categoriesCount = (int)cmdCountOfCategories.ExecuteScalar();

            Console.WriteLine("Count of Categories - {0}", categoriesCount);
            Console.ReadLine();
        }
    }
}
