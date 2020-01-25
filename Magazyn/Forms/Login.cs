using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using Magazyn.Forms;
using Magazyn.Classes;

namespace Magazyn
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            GlobalSettings.RestoreDefaults();
            box_login.Focus();
            box_login.Select(0, 0);
        }

        private void Login_Button(object sender, EventArgs e)
        {

            using (MySqlConnection connection = new Connection().GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM users WHERE login=@login";
                    SHA256Hasher hasher = new SHA256Hasher();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@login", box_login.Text);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        GlobalSettings.Hash = reader["password"].ToString();
                        GlobalSettings.Salt = reader["salt"].ToString();
                        string hash_input = hasher.GenerateHash(GlobalSettings.Salt, box_pass.Text);
                        if (GlobalSettings.Hash == hash_input)
                        {
                            reader.Read();
                            GlobalSettings.UserID = Convert.ToUInt32(reader["user_id"]);
                            GlobalSettings.UserName = reader["login"].ToString();
                            GlobalSettings.Name = reader["name"].ToString();
                            GlobalSettings.Surname = reader["surname"].ToString();
                            GlobalSettings.Permission = Convert.ToByte(reader["permission"]);

                            WareHouseMenu menu = new WareHouseMenu();
                            menu.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Niepoprawny login/hasło");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawny login/hasło");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Number}");
                }
            }
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
