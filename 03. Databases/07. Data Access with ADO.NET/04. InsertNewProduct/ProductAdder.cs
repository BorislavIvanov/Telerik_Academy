using System;
using System.Data.SqlClient;

class ProductAdder
{
    static void Main()
    {
        AddProductIntoDB("Vafla BateBoiko");
    }

    private static void AddProductIntoDB(string name)
    {
        SqlConnection sqlConnect = new SqlConnection("Server=BOBBY-PC; " +
            "Database=NORTHWND; Integrated Security=true");

        sqlConnect.Open();

        using (sqlConnect)
        {
            SqlCommand cmdAddNewProduct = new SqlCommand(
                "INSERT INTO Products(ProductName) VALUES (@name)",
                sqlConnect);

            cmdAddNewProduct.Parameters.AddWithValue("@name", name);
            cmdAddNewProduct.ExecuteNonQuery();
        }
    }
}
