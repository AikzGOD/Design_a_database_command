using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_database_connection
{
    internal class SqlConnection : DbConnection
    {

        private string connectionString;

        public SqlConnection(string ConnectionString) 
            : base(ConnectionString)
        {
            this.connectionString = ConnectionString;
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SqlConnedction Closed...");

        }

        public override void OpenConnection()
        {
            Console.WriteLine("SqlConnedction Opened ...");

        }

        
    }
}
