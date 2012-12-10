namespace IPStoreManager.GUI.Forms.SalesManagement
{
    partial class frmEditSalesItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pRODUCTNAMEDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.sUPPLIERNAMEDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClearProductFilter = new System.Windows.Forms.Button();
            this.btnClearSupplierFilter = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.Location = new System.Drawing.Point(7, 370);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 13);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(95, 367);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(99, 20);
            this.tbQuantity.TabIndex = 0;
            this.tbQuantity.Text = "1";
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            this.tbQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQuantity_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Location = new System.Drawing.Point(7, 164);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(111, 13);
            this.lblProductName.TabIndex = 23;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(10, 180);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(181, 20);
            this.tbProductName.TabIndex = 2;
            this.tbProductName.TextChanged += new System.EventHandler(this.tbProductName_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUCTNAMEDataGridViewTextBox,
            this.dESCRIPTIONDataGridViewTextBox,
            this.pRICEDataGridViewTextBox});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.dgvProducts.Location = new System.Drawing.Point(2, 205);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.ShowCellErrors = false;
            this.dgvProducts.ShowCellToolTips = false;
            this.dgvProducts.ShowEditingIcon = false;
            this.dgvProducts.ShowRowErrors = false;
            this.dgvProducts.Size = new System.Drawing.Size(570, 152);
            this.dgvProducts.StandardTab = true;
            this.dgvProducts.TabIndex = 18;
            // 
            // pRODUCTNAMEDataGridViewTextBox
            // 
            this.pRODUCTNAMEDataGridViewTextBox.DataPropertyName = "Name";
            this.pRODUCTNAMEDataGridViewTextBox.HeaderText = "Product Name";
            this.pRODUCTNAMEDataGridViewTextBox.Name = "pRODUCTNAMEDataGridViewTextBox";
            this.pRODUCTNAMEDataGridViewTextBox.ReadOnly = true;
            this.pRODUCTNAMEDataGridViewTextBox.Width = 150;
            // 
            // dESCRIPTIONDataGridViewTextBox
            // 
            this.dESCRIPTIONDataGridViewTextBox.DataPropertyName = "Description";
            this.dESCRIPTIONDataGridViewTextBox.HeaderText = "Description";
            this.dESCRIPTIONDataGridViewTextBox.Name = "dESCRIPTIONDataGridViewTextBox";
            this.dESCRIPTIONDataGridViewTextBox.ReadOnly = true;
            this.dESCRIPTIONDataGridViewTextBox.Width = 300;
            // 
            // pRICEDataGridViewTextBox
            // 
            this.pRICEDataGridViewTextBox.DataPropertyName = "Price";
            this.pRICEDataGridViewTextBox.HeaderText = "Price";
            this.pRICEDataGridViewTextBox.Name = "pRICEDataGridViewTextBox";
            this.pRICEDataGridViewTextBox.ReadOnly = true;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplierName.Location = new System.Drawing.Point(7, 5);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(111, 13);
            this.lblSupplierName.TabIndex = 22;
            this.lblSupplierName.Text = "Supplier Name:";
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(10, 21);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(181, 20);
            this.tbSupplierName.TabIndex = 1;
            this.tbSupplierName.TextChanged += new System.EventHandler(this.tbSupplierName_TextChanged);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUPPLIERNAMEDataGridViewTextBox});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.dgvSuppliers.Location = new System.Drawing.Point(2, 46);
            this.dgvSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.ShowCellErrors = false;
            this.dgvSuppliers.ShowCellToolTips = false;
            this.dgvSuppliers.ShowEditingIcon = false;
            this.dgvSuppliers.ShowRowErrors = false;
            this.dgvSuppliers.Size = new System.Drawing.Size(569, 111);
            this.dgvSuppliers.StandardTab = true;
            this.dgvSuppliers.TabIndex = 16;
            // 
            // sUPPLIERNAMEDataGridViewTextBox
            // 
            this.sUPPLIERNAMEDataGridViewTextBox.DataPropertyName = "Name";
            this.sUPPLIERNAMEDataGridViewTextBox.HeaderText = "Supplier Name";
            this.sUPPLIERNAMEDataGridViewTextBox.Name = "sUPPLIERNAMEDataGridViewTextBox";
            this.sUPPLIERNAMEDataGridViewTextBox.ReadOnly = true;
            this.sUPPLIERNAMEDataGridViewTextBox.Width = 400;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(416, 411);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(497, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClearProductFilter
            // 
            this.btnClearProductFilter.AutoSize = true;
            this.btnClearProductFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearProductFilter.Location = new System.Drawing.Point(197, 177);
            this.btnClearProductFilter.Name = "btnClearProductFilter";
            this.btnClearProductFilter.Size = new System.Drawing.Size(41, 24);
            this.btnClearProductFilter.TabIndex = 3;
            this.btnClearProductFilter.Text = "Clear";
            this.btnClearProductFilter.UseVisualStyleBackColor = true;
            this.btnClearProductFilter.Click += new System.EventHandler(this.btnClearProductFilter_Click);
            // 
            // btnClearSupplierFilter
            // 
            this.btnClearSupplierFilter.AutoSize = true;
            this.btnClearSupplierFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearSupplierFilter.Location = new System.Drawing.Point(197, 18);
            this.btnClearSupplierFilter.Name = "btnClearSupplierFilter";
            this.btnClearSupplierFilter.Size = new System.Drawing.Size(41, 24);
            this.btnClearSupplierFilter.TabIndex = 1;
            this.btnClearSupplierFilter.Text = "Clear";
            this.btnClearSupplierFilter.UseVisualStyleBackColor = true;
            this.btnClearSupplierFilter.Click += new System.EventHandler(this.btnClearSupplierFilter_Click);
            // 
            // frmEditSalesItem
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(579, 440);
            this.Controls.Add(this.btnClearProductFilter);
            this.Controls.Add(this.btnClearSupplierFilter);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmEditSalesItem";
            this.Text = "{0} Sale Item";
            this.Load += new System.EventHandler(this.frmEditSalesItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearProductFilter;
        private System.Windows.Forms.Button btnClearSupplierFilter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERNAMEDataGridViewTextBox;
    }
}