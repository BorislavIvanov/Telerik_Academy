using System;
using System.Data.OleDb;

class Program
{
    static void Main()
    {
        InsertDataIntoEcxel("234", "Kaspichan :)");
    }

    static void InsertDataIntoEcxel(string townID, string townName)
    {
        OleDbConnection dbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
             @"Data Source=C:\Users\BoBBy\Desktop\DataAccessWithADO.NET-Homework\07. InsetrDataIntoExcel\ExcelFile.xlsx;Extended Properties=""Excel 12.0 XML;HDR=Yes""");

        dbConn.Open();

        using (dbConn)
        {
            OleDbCommand myCommand = new OleDbCommand("INSERT INTO [Sheet1$] (TownID,Name) VALUES (@townID,@townName)", dbConn);

            myCommand.Parameters.AddWithValue("@townID", townID);
            myCommand.Parameters.AddWithValue("@townName", townName);
            myCommand.ExecuteNonQuery();
        }
    }
}
