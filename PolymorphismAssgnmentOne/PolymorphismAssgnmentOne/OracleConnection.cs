using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssgnmentOne
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        { }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle Connection: " + ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle Connection.");
        }
    }
}
