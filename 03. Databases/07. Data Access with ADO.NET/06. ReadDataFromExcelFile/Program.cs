using System;
using System.Data;
using System.Data.OleDb;

class Program
{
    static void Main()
    {
        OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=C:\Users\BoBBy\Desktop\DataAccessWithADO.NET-Homework\06. ReadDataFromExcelFile\ExcelFile.xlsx;Extended Properties=""Excel 12.0 XML;HDR=Yes""");

        dbConnection.Open();

        using (dbConnection)
        {
            OleDbCommand cmdReadAllFromFirstSheet = new OleDbCommand("SELECT * FROM [Sheet1$]", dbConnection);

            OleDbDataReader reader = cmdReadAllFromFirstSheet.ExecuteReader();

            while (reader.Read())
            {
                string townID = (string)reader["TownID"];
                string townName = (string)reader["Name"];
                Console.WriteLine("{0} -> {1}", townID, townName);
            }
        }
    }
}
