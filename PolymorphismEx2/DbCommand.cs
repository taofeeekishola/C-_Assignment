
namespace Polymorphism
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _dbinstruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("DbConnection cannot be null.");

            if (string.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Instruction cannot be null or empty.");

            _dbConnection = dbConnection;
            _dbinstruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.open(); // Open connection
            Console.WriteLine($"Executing instruction: {_dbinstruction}");
            _dbConnection.close(); // Close connection
        }
    }
}
