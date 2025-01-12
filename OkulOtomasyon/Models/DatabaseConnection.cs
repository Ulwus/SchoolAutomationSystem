using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace OkulOtomasyon.Models
{
    public class DatabaseConnection
    {
        private static readonly string connectionString = "Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;";
        private static DatabaseConnection instance;
        private MySqlConnection connection;

        private DatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }

        public MySqlConnection GetConnection()
        {
            if (connection == null || connection.State != ConnectionState.Open)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
} 