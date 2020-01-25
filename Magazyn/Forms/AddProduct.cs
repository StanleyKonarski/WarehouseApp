using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Magazyn.Interfaces;


namespace Magazyn.Forms
{
    public partial class AddProduct : Form, IValidation
    {
        public AddProduct()
        {
            InitializeComponent();
            
        }

        public bool Validation()
        {
            if (string.IsNullOrWhiteSpace(ProductNameBox.Text) ||
               string.IsNullOrWhiteSpace(ProductColorBox.Text) )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddItem_Clck(object sender, EventArgs e)
        {

            if (Validation())
            {
                using (MySqlConnection connection = new Connection().GetConnection())
                {
                    DataGetter data = new DataGetter();
                    try
                    {

                        if (data.ExistCheck($"SELECT * FROM wheels where ProductID='{ProductIdBox.Value}' OR ProductName='{ProductNameBox.Text}'"))
                        {
                            MessageBox.Show("Produkt z takim ID lub nazwą istnieje już w bazie!");
                        }
                        else
                        {
                            string query = "INSERT INTO wheels (ProductID,ProductName,ProductColor,WheelDiameter,WheelWidth,Quantity) " +
                                           "VALUES(@ID, @Name, @Color, @Diameter, @Width, @Quantity);";
                            MySqlCommand cmd = new MySqlCommand(query, connection);

                            cmd.Parameters.AddWithValue("@ID", ProductIdBox.Value);
                            cmd.Parameters.AddWithValue("@Name", ProductNameBox.Text);
                            cmd.Parameters.AddWithValue("@Color", ProductColorBox.Text);
                            cmd.Parameters.AddWithValue("@Diameter", ProductDiameterBox.Value);
                            cmd.Parameters.AddWithValue("@Width", ProductWidthBox.Value);
                            cmd.Parameters.AddWithValue("@Quantity", ProductQuantityBox.Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Pomyślnie dodano produkt do bazy!");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error: {ex.Number}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
            }
        
            
        }
    }
}
