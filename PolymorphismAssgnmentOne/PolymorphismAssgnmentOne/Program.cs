using System;
using System.Data.Common;
using PolymorphismAssgnmentOne;

class Program
{
    static void Main(string[] args)
    {
        // Demonstrate usage with SQL Connection
        PolymorphismAssgnmentOne.DbConnection sqlConnection = new SqlConnection("Server=myServer;Database=myDB;");
        PolymorphismAssgnmentOne.DbCommand sqlCommand = new PolymorphismAssgnmentOne.DbCommand(sqlConnection, "SELECT * FROM Users");
        sqlCommand.Execute();

        Console.WriteLine();

        // Demonstrate usage with Oracle Connection
        PolymorphismAssgnmentOne.DbConnection oracleConnection = new OracleConnection("Host=myOracleServer;DB=myOracleDB;");
        PolymorphismAssgnmentOne.DbCommand oracleCommand = new PolymorphismAssgnmentOne.DbCommand(oracleConnection, "SELECT * FROM Customers");
        oracleCommand.Execute();

        // Uncommenting the following would throw an exception due to invalid arguments:
        // DbCommand invalidCommand = new DbCommand(null, "");
    }
}
