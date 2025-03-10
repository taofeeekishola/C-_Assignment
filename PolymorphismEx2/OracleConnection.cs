using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void open()// overriding the defined method in DbConnection
        {
            Console.WriteLine("Opening Oracle Connection string");
        }

        public override void close()
        {
            Console.WriteLine("Closing Oracle Connection string");
        }
    }
}
