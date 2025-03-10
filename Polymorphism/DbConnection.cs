using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class DbConnection
    {
        public  string ConnectionString { get; private set; }

        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Invalid input");
            }

            ConnectionString = connectionString;
            Timeout = TimeSpan.FromSeconds(30); // Default timeout
        }

        public abstract void open(); // Abstract method to be implemented by derived classes
        public abstract void close(); 



    }
}

