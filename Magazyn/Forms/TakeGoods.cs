using System;
using System.Windows.Forms;
using Magazyn.Classes;
using MySql;
using MySql.Data.MySqlClient;
using Magazyn.Interfaces;
using static Magazyn.Classes.GlobalSettings;


namespace Magazyn.Forms
{
    public partial class TakeGoods : Form, IValidation
    {
        
        public TakeGoods()
        {
            InitializeComponent();
            ProductNameCB.DataSource = new DataGetter().GetProductNameList();
            ProductNameCB.DisplayMember="ProductName";
        }


        public bool Validation()
        {
            if (ProductQuantityBox.Value == 0) return false;
            else return true;

        }

        private void AddGoods_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                using (MySqlConnection connection = new Connection().GetConnection())
                {
                    try
                    {
                        string query = "UPDATE wheels SET Quantity=Quantity+@value where ProductName=@ProductName;";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("ProductName", ProductNameCB.Text);
                        command.Parameters.AddWithValue("value", ProductQuantityBox.Value);
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Pomyślnie zwiększono ilość produktu: {ProductNameCB.Text} o {ProductQuantityBox.Value}");
                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show($"Error: {ex.Number}");
                    }
                   

                }
            }
            else
            {
                MessageBox.Show("Wartość dodawana musi byc wieksza od zera!");
            }
        }
    }
}
