using Magazyn.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn.Forms
{
    public partial class WareHouseMenu : Form
    {
        public WareHouseMenu()
        {
            InitializeComponent();
            label_username.Text = $"Zalogowany: {GlobalSettings.Name} {GlobalSettings.Surname} [ID: {GlobalSettings.UserID}]";
            if (GlobalSettings.Permission == 1)
            {
                addNewProduct.Enabled = false;
                AddEmployee.Enabled = false;
                EmployeeList.Enabled = false;
            }
        }


        private void Logout_Click(object sender, EventArgs e)
        {
            GlobalSettings.RestoreDefaults();
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Close();
            Application.Restart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReleaseGoods_Click(object sender, EventArgs e)
        {
            ReleaseGoods releaseGoods = new ReleaseGoods();
            releaseGoods.Show();
        }

        private void TakeGoods_Click(object sender, EventArgs e)
        {
            TakeGoods takeGoods = new TakeGoods();
            takeGoods.Show();
        }

        private void ShowStatus_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView();
            dataView.Show();
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void WorkersTab_Click(object sender, EventArgs e)
        {
            WorkersTab workersTab = new WorkersTab();
            workersTab.Show();
        }
    }
}
