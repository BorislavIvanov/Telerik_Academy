using System;
using System.Data.SqlClient;

class GettingAllNamesAndDescriptions
{
    static void Main(string[] args)
    {
        SqlConnection sqlConnect = new SqlConnection("Server=BOBBY-PC; " +
            "Database=NORTHWND; Integrated Security=true");

        sqlConnect.Open();

        using (sqlConnect)
        {
            SqlCommand cmdGetAllNamesAndDescriptions = new SqlCommand(
                "SELECT CategoryName, Description FROM Categories", sqlConnect);

            SqlDataReader reader = cmdGetAllNamesAndDescriptions.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0} - {1}", name, description);
                }
            }
        }
    }
}
