using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_database_connection
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string ConnectionString) 
            : base(ConnectionString)
        {

        }

        public override void CloseConnection()
        {
            Console.WriteLine("OracleConnection Closed...");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("OracleConnection Opened...");

        }
    }
}
