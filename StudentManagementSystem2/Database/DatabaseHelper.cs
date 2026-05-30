using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem2.Database
{
    // Central class for all database operations
    public class DatabaseHelper
    {
        // MySQL connection string - change 'your_password' to your MySQL password
        private static string connectionString =
    "Server=localhost;Database=StudentManagementDB;Uid=root;Pwd=maria2431hashir;";
        // Opens and returns a MySQL connection
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        // Runs INSERT / UPDATE / DELETE queries
        // Returns rows affected
        public static int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Runs SELECT queries
        // Returns results as DataTable
        public static DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // Tests database connection
        // Returns true if connected successfully
        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    return conn.State == ConnectionState.Open;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}