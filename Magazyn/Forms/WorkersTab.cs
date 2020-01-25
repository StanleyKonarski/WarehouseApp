using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // do tego trzeba zainstalować mysql connector z neta bo inaczej nie znajdziesz tego w extensions

namespace Magazyn
{
    public partial class WorkersTab : Form
    {
        public WorkersTab()
        {
            InitializeComponent();
            ShowProducts();
        }
        private void ShowProducts()
        {
            try
            {
                #region StareLOGOWANIE
                /*MySqlConnection connection = new MySqlConnection("Server=k18.unixstorm.org;Database=adriannowa_db1;Uid=adriannowa_stachu;Pwd=*******;");
        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM wheels", connection);
        connection.Open();
        DataSet dataset = new DataSet();
        adapter.Fill(dataset, "wheels");
        dataGridView1.DataSource = dataset.Tables["wheels"];
        connection.Close();*/ 
                #endregion
                DataGetter datagetter = new DataGetter();
                DataSet dataset = datagetter.WorkersTab();
                dataGridView1.DataSource = dataset.Tables["users"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Refresh_Button(object sender, EventArgs e)
        {
            ShowProducts();
        }
    }
}
