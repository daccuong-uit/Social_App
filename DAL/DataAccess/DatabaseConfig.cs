using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccess
{
    public static class DatabaseConfig
    {
        private static readonly string _connectionString = "Server=your_server;Database=your_database;User Id=your_username;Password=your_password;";

        public static string ConnectionString => _connectionString;
    }
}
