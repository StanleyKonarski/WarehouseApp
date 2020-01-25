 using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Magazyn
{
    class Connection
    {
        private MySqlConnection connection;
        private MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();
        public Connection()
        {
            SetConnectionString("localhost", "kolka", "root", "");
            
            connection = new MySqlConnection(GetConnectionString());
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error:{ex.Number}");
            }
        }

        private void SetConnectionString(string server, string database, string userid, string password)
        {
            connectionStringBuilder.Server = server;
            connectionStringBuilder.Database = database;
            connectionStringBuilder.UserID = userid;
            connectionStringBuilder.Password = password;
        }

        private string GetConnectionString()
        {
            return connectionStringBuilder.ToString();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
