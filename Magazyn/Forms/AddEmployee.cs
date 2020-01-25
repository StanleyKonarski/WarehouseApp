using System;
using System.Windows.Forms;
using Magazyn.Classes;
using MySql;
using MySql.Data.MySqlClient;
using Magazyn.Interfaces;
using static Magazyn.Classes.GlobalSettings;


namespace Magazyn.Forms
{
    public partial class AddEmployee : Form, IValidation
    {

        public AddEmployee()
        {
            InitializeComponent();
            PositionComboBox.DataSource = Enum.GetValues(typeof(Position));
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            DataGetter data = new DataGetter();
            if (Validation())
            {
                if (data.ExistCheck($"SELECT * FROM users WHERE login='{LoginTextBox.Text}'"))
                {
                    MessageBox.Show($"Użytkownik o loginie {LoginTextBox.Text} już istnieje, użyj innej nazwy!");
                }
                else
                {
                    using (MySqlConnection connection = new Connection().GetConnection())
                    {
                        try
                        {
                            string query = "INSERT INTO users (login,name,surname,permission,password,salt)" +
                                           " VALUES(@login, @name, @surname, @permission, @password, @salt);";
                            Salter salter = new Salter();
                            string salt = salter.GenerateSalt();
                            SHA256Hasher hasher = new SHA256Hasher();
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("login", LoginTextBox.Text);
                            command.Parameters.AddWithValue("name", nameTextBox.Text);
                            command.Parameters.AddWithValue("surname", SurnameTextBox.Text);
                            command.Parameters.AddWithValue("permission", (int)GetPositionValue());
                            command.Parameters.AddWithValue("password", hasher.GenerateHash(salt, PasswordTextBox.Text));
                            command.Parameters.AddWithValue("salt", salt);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Pomyślnie dodano pracownika");
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Error: {ex.Number}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }

        }
        private Position GetPositionValue()
        {
            return (Position)PositionComboBox.SelectedItem;
        }
        public bool Validation()
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(SurnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LoginTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
