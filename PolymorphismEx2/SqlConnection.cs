namespace Polymorphism
{
    public class SqlConnection : DbConnection // inheritance
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

        public override void open() // overriding the defined method in DbConnection
        {
            Console.WriteLine("Opening  SQL Connection string");
        } 

        public override void close()
        {
            Console.WriteLine("Closing SQL Connection string");
        }


    }
}
