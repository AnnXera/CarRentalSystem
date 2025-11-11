using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Database
{
    internal class SQLDBHelper
    {
        private static SQLDBHelper _instance;
        private static readonly object _lock = new object();
        private readonly MySqlConnection _connection;

        private SQLDBHelper()
        {
            string connectionString = "server=127.0.0.1;user=root;database=car_rental_system;password=";
            _connection = new MySqlConnection(connectionString);
        }

        public static SQLDBHelper Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new SQLDBHelper();
                    return _instance;
                }
            }
        }

        public MySqlConnection Connection => _connection;

        public void Open()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        public void Close()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }
    }
}
