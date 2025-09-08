using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseRelated.Connection
{
    public class DatabaseConnection
    {
        private const string _connectionString = "server=localhost;user=root;password=root;database=busdb";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
