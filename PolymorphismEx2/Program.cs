
using Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        // Using SQL Server Connection
        DbConnection sqlConnection = new SqlConnection("Server=myServer;Database=myDB;");
        DbCommand sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users;");
        sqlCommand.Execute();

        Console.WriteLine();

        // Using Oracle Connection
        DbConnection oracleConnection = new OracleConnection("Host=myOracleServer;DB=myOracleDB;");
        DbCommand oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Employees;");
        oracleCommand.Execute();

    }

}

