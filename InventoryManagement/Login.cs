using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=NB-ZALEWSKI\NAVDEMO;Initial Catalog=InventorySystem;Integrated Security=True";
            string getLoginInfo = "SELECT * FROM [InventorySystem].[dbo].[Login] WHERE UserName='" + UserNameTextBox.Text.Trim() + "' AND Password ='" + PasswordTextBox.Text.Trim() + "'";

            SqlConnection sqlConnection = new SqlConnection(connString);
            //SqlCommand sqlGetLoginInfo = new SqlCommand(getLoginInfo);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(getLoginInfo, connString);
            DataTable loginDataTable = new DataTable();
            sqlDataAdapter.Fill(loginDataTable);

            if (loginDataTable.Rows.Count >= 1)
            {
                Hide();
                InventoryMainForm inventoryMainForm = new InventoryMainForm();
                inventoryMainForm.Show();
            }
            else
            {
                MessageBox.Show("Incorect login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
            UserNameTextBox.Focus();
        }
    }
}
