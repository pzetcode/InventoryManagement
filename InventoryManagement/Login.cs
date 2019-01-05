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
        public string _DataSource = @"NB-ZALEWSKI\NAVDEMO";
        public string _InitialCatalog = "InventorySystem";

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
                stringBuilder.DataSource = _DataSource;
                stringBuilder.InitialCatalog = _InitialCatalog;
                stringBuilder.IntegratedSecurity = true;

                string getLoginInfo = "SELECT * FROM [InventorySystem].[dbo].[Login] WHERE UserName='" + UserNameTextBox.Text.Trim() + "' AND Password ='" + PasswordTextBox.Text.Trim() + "'";

                using (SqlConnection sqlConnection = new SqlConnection(stringBuilder.ConnectionString))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(getLoginInfo, stringBuilder.ConnectionString))
                    {
                        using (DataTable loginDataTable = new DataTable())
                        {
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
                                ClearTextBoxes();
                            }
                        }                                               
                    }                                       
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        public void ClearTextBoxes()
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
            UserNameTextBox.Focus();

        }

        public void DeleteRow(string rowID){
            try
            {
                SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
                stringBuilder.DataSource = _DataSource;
                stringBuilder.InitialCatalog = _InitialCatalog;
                stringBuilder.IntegratedSecurity = true;
            
                using (SqlConnection sqlConnection = new SqlConnection(stringBuilder.ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM [InventorySystem].[dbo].[Products] WHERE ProductID='" + int.Parse(rowID) + "'", sqlConnection))
                    {
                        command.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show(rowID);
        }
        
    }
}
