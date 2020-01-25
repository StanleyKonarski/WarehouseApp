using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Magazyn
{
    class DataGetter
    {
        public DataSet InventoryStatus()
        {
            using (MySqlConnection connection = new Connection().GetConnection())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM wheels", connection);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "wheels");
                return dataset;
            }

        }
        public DataSet WorkersTab()
        {
            using (MySqlConnection connection = new Connection().GetConnection())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT user_id as ID, login as 'Login', name as Name, surname as Surname FROM users", connection);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "users");
                return dataset;
            }

        }
        public bool ExistCheck(string query)
        {
            try
            {
                using (MySqlConnection connection = new Connection().GetConnection())
                {
                    MySqlCommand command = new MySqlCommand(query,connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows) return true;
                    else return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable GetProductNameList()
        {
            DataTable dataSet = new DataTable();
            using (MySqlConnection connection = new Connection().GetConnection())
            {
                string query = "SELECT ProductName FROM wheels";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                dataAdapter.Fill(dataSet);
            }
            return dataSet;
        }

    }
}
