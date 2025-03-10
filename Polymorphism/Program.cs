
using Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        DbConnection sqlConnect = new SqlConnection("Server=myServer;Database=myDB;");
        sqlConnect.open();
        sqlConnect.close();

        Console.WriteLine();

        DbConnection oracleConnect = new OracleConnection("Host=myOracleServer;DB=myOracleDB;");
        oracleConnect.open();
        oracleConnect.close();

        // Uncommenting the following will throw an exception:
        //DbConnection invalidConnect = new SqlConnection("");
    }

}

