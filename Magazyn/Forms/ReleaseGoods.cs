using System;
using System.Windows.Forms;
using Magazyn.Classes;
using MySql;
using MySql.Data.MySqlClient;
using Magazyn.Interfaces;
using static Magazyn.Classes.GlobalSettings;


namespace Magazyn.Forms
{
    public partial class ReleaseGoods : Form, IValidation
    {
        
        public ReleaseGoods()
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

        public bool QuantityCheck(MySqlConnection connection, string query, int quantityTaken,MySqlTransaction a)
        {
            int quantityActual=0;
            MySqlCommand command = new MySqlCommand(query, connection,a);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                quantityActual = (int)reader["Quantity"];
            }

            reader.Close();
            if (quantityActual-quantityTaken>=0) return true;
            else return false;
            
        }
        private void ReleaseGoods_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                using (MySqlConnection connection = new Connection().GetConnection())
                {
                    MySqlTransaction transaction = null;
                    try
                    {
                        transaction = connection.BeginTransaction();
                        if (QuantityCheck(connection,$"SELECT Quantity FROM wheels WHERE ProductName='{ProductNameCB.Text}'",(int)ProductQuantityBox.Value,transaction))
                        {
                            string query = "UPDATE wheels SET Quantity=Quantity-@value where ProductName=@ProductName;";
                            MySqlCommand command = new MySqlCommand(query, connection, transaction);
                            command.Parameters.AddWithValue("ProductName", ProductNameCB.Text);
                            command.Parameters.AddWithValue("value", ProductQuantityBox.Value);
                            command.ExecuteNonQuery();
                            transaction.Commit();
                            MessageBox.Show($"Pomyślnie pomniejszono ilość produktu: {ProductNameCB.Text} o {ProductQuantityBox.Value}");
                        }
                        else
                        {
                            MessageBox.Show("W magazynie nie ma takiej ilości produktu");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch(MySqlException exx)
                        {
                            MessageBox.Show($"Error: {exx.Message}");
                        }
                        MessageBox.Show($"Error: {ex.Message}");
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
