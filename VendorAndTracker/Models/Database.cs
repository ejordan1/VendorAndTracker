using System;
using MySql.Data.MySqlClient;
using VendorAndTracker;

namespace VendorAndTracker.Models
{
    public class DB
    {
        public static MySqlConnection Connection()
        {
            MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
            return conn;
        }
    }
}
