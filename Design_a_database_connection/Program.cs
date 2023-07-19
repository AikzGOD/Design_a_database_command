using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_database_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("XYZ1234");

            sqlConnection.OpenConnection();

            sqlConnection.CloseConnection();

            OracleConnection oracleConnection = new OracleConnection("1234XYZ");

            oracleConnection.OpenConnection();

            oracleConnection.CloseConnection();

        }
    }
}
