using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseRelated.Connection
{
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private static readonly object _lock = new object();

        private const string ConnectionString = "server=localhost;user=root;password=root;database=busdb";


        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new DatabaseConnection();
                        }
                    }
                }
                return instance;
            }
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
