using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_database_connection
{
    internal abstract class DbConnection
    {

        /*
         * Our DbConnection must have 2 Methods (Open and Close) , those methods
         * need to be abstract and set on the derived Class.
         */

        /// <summary>
        /// If DbConnection doesn't have connection string is not valid
        /// To avoid this, let's pass it the constructor of the class
        /// Validate if the Connection string is empty or null
        /// If the connection could not be opened within the timeout, show an ExceptionError
        /// </summary>
        private string ConnectionString { get; set; }

        /// <summary>
        /// Timeout limit time will be 30 seconds
        /// </summary>
        private TimeSpan TimeOut
        {
            get { return TimeOut; }
            set { TimeOut = TimeSpan.FromSeconds(30); }
        }

        public DbConnection(string ConnectionString)
        {
            if (String.IsNullOrEmpty(ConnectionString)) throw new ArgumentNullException();
            this.ConnectionString = ConnectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
        


    }
}
