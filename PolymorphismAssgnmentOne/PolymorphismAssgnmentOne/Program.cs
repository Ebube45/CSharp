using System;
using System.Data.Common;
using PolymorphismAssgnmentOne;

class Program
{
    static void Main(string[] args)
    {
        // Testing SQL Connection
        PolymorphismAssgnmentOne.DbConnection sqlConnect = new SqlConnection("Server=myServer;Database=myDB;");
        sqlConnect.Open();
        sqlConnect.Close();

        Console.WriteLine();

        // Testing Oracle Connection
        PolymorphismAssgnmentOne.DbConnection oracleConnect = new OracleConnection("Host=myOracleServer;DB=myOracleDB;");
        oracleConnect.Open();
        oracleConnect.Close();

        // Uncommenting the following line would throw an exception due to an invalid connection string:
        // DbConnection invalidConnect = new SqlConnection("");
    }
}
