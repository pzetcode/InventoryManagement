using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventorySystemDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.inventorySystemDataSet.Products);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillBy(this.inventorySystemDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        
        private void buttonGridDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                string pkValue = dataGridView1[0, item.Index].Value.ToString();
                Login login = new Login();
                login.DeleteRow(pkValue);
                dataGridView1.Rows.RemoveAt(item.Index);            
            }
        }

        private void buttonGridAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxProdName.Text))
            {
                MessageBox.Show("Product name seems to be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Login login = new Login();

                if (checkBoxStatus.Checked)
                {
                    login.AddRow(textBoxProdName.Text, 1);
                }
                else
                {
                    login.AddRow(textBoxProdName.Text, 0);
                }


            }

        }
    }
}
