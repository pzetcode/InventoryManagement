namespace InventoryManagement
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventorySystemDataSet = new InventoryManagement.InventorySystemDataSet();
            this.productsTableAdapter = new InventoryManagement.InventorySystemDataSetTableAdapters.ProductsTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buttonGridDelete = new System.Windows.Forms.Button();
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.buttonGridAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySystemDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productStatusDataGridViewCheckBoxColumn
            // 
            this.productStatusDataGridViewCheckBoxColumn.DataPropertyName = "ProductStatus";
            this.productStatusDataGridViewCheckBoxColumn.HeaderText = "Product Status";
            this.productStatusDataGridViewCheckBoxColumn.Name = "productStatusDataGridViewCheckBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.inventorySystemDataSet;
            // 
            // inventorySystemDataSet
            // 
            this.inventorySystemDataSet.DataSetName = "InventorySystemDataSet";
            this.inventorySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(645, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.fillByToolStripButton.Text = "Refresh data";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // buttonGridDelete
            // 
            this.buttonGridDelete.Location = new System.Drawing.Point(547, 28);
            this.buttonGridDelete.Name = "buttonGridDelete";
            this.buttonGridDelete.Size = new System.Drawing.Size(86, 23);
            this.buttonGridDelete.TabIndex = 2;
            this.buttonGridDelete.Text = "Delete row(s)";
            this.buttonGridDelete.UseVisualStyleBackColor = true;
            this.buttonGridDelete.Click += new System.EventHandler(this.buttonGridDelete_Click);
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(94, 29);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(256, 20);
            this.textBoxProdName.TabIndex = 3;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(366, 31);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(56, 17);
            this.checkBoxStatus.TabIndex = 4;
            this.checkBoxStatus.Text = "Status";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // buttonGridAdd
            // 
            this.buttonGridAdd.Location = new System.Drawing.Point(428, 28);
            this.buttonGridAdd.Name = "buttonGridAdd";
            this.buttonGridAdd.Size = new System.Drawing.Size(95, 23);
            this.buttonGridAdd.TabIndex = 5;
            this.buttonGridAdd.Text = "Add new row";
            this.buttonGridAdd.UseVisualStyleBackColor = true;
            this.buttonGridAdd.Click += new System.EventHandler(this.buttonGridAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product name:";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGridAdd);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.textBoxProdName);
            this.Controls.Add(this.buttonGridDelete);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductsForm";
            this.Text = "Products Grid";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySystemDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InventorySystemDataSet inventorySystemDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private InventorySystemDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn productStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button buttonGridDelete;
        private System.Windows.Forms.TextBox textBoxProdName;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.Button buttonGridAdd;
        private System.Windows.Forms.Label label1;
    }
}