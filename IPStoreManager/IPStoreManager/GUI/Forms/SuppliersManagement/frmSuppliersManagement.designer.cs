namespace IPStoreManager.GUI.Forms.SuppliersManagement
{
    partial class frmSuppliersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliersManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsSuppliersMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnNewSupplier = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditSupplier = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRemoveSupplier = new System.Windows.Forms.ToolStripButton();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.sUPPLIERNAMEDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsProductsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnNewProduct = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditProduct = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRemoveProduct = new System.Windows.Forms.ToolStripButton();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pRODUCTNAMEDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsSuppliersMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.tsProductsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tsSuppliersMenu
            // 
            this.tsSuppliersMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.tsSuppliersMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSuppliersMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNewSupplier,
            this.tsbtnEditSupplier,
            this.tsbtnRemoveSupplier});
            this.tsSuppliersMenu.Location = new System.Drawing.Point(0, 0);
            this.tsSuppliersMenu.Name = "tsSuppliersMenu";
            this.tsSuppliersMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsSuppliersMenu.Size = new System.Drawing.Size(553, 25);
            this.tsSuppliersMenu.TabIndex = 0;
            this.tsSuppliersMenu.Text = "toolStrip1";
            // 
            // tsbtnNewSupplier
            // 
            this.tsbtnNewSupplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNewSupplier.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNewSupplier.Image")));
            this.tsbtnNewSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewSupplier.Name = "tsbtnNewSupplier";
            this.tsbtnNewSupplier.Size = new System.Drawing.Size(35, 22);
            this.tsbtnNewSupplier.Text = "New";
            this.tsbtnNewSupplier.Click += new System.EventHandler(this.tsbtnNewSupplier_Click);
            // 
            // tsbtnEditSupplier
            // 
            this.tsbtnEditSupplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnEditSupplier.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditSupplier.Image")));
            this.tsbtnEditSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditSupplier.Name = "tsbtnEditSupplier";
            this.tsbtnEditSupplier.Size = new System.Drawing.Size(31, 22);
            this.tsbtnEditSupplier.Text = "Edit";
            this.tsbtnEditSupplier.Click += new System.EventHandler(this.tsbtnEditSupplier_Click);
            // 
            // tsbtnRemoveSupplier
            // 
            this.tsbtnRemoveSupplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnRemoveSupplier.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRemoveSupplier.Image")));
            this.tsbtnRemoveSupplier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRemoveSupplier.Name = "tsbtnRemoveSupplier";
            this.tsbtnRemoveSupplier.Size = new System.Drawing.Size(54, 22);
            this.tsbtnRemoveSupplier.Text = "Remove";
            this.tsbtnRemoveSupplier.Click += new System.EventHandler(this.tsbtnRemoveSupplier_Click);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUPPLIERNAMEDataGridViewTextBox,
            this.aDDRESSDataGridViewTextBox});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.dgvSuppliers.Location = new System.Drawing.Point(1, 24);
            this.dgvSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.ShowCellErrors = false;
            this.dgvSuppliers.ShowCellToolTips = false;
            this.dgvSuppliers.ShowEditingIcon = false;
            this.dgvSuppliers.ShowRowErrors = false;
            this.dgvSuppliers.Size = new System.Drawing.Size(552, 208);
            this.dgvSuppliers.TabIndex = 2;
            // 
            // sUPPLIERNAMEDataGridViewTextBox
            // 
            this.sUPPLIERNAMEDataGridViewTextBox.DataPropertyName = "Name";
            this.sUPPLIERNAMEDataGridViewTextBox.HeaderText = "Supplier Name";
            this.sUPPLIERNAMEDataGridViewTextBox.Name = "sUPPLIERNAMEDataGridViewTextBox";
            this.sUPPLIERNAMEDataGridViewTextBox.ReadOnly = true;
            this.sUPPLIERNAMEDataGridViewTextBox.Width = 150;
            // 
            // aDDRESSDataGridViewTextBox
            // 
            this.aDDRESSDataGridViewTextBox.DataPropertyName = "Address";
            this.aDDRESSDataGridViewTextBox.HeaderText = "Address";
            this.aDDRESSDataGridViewTextBox.Name = "aDDRESSDataGridViewTextBox";
            this.aDDRESSDataGridViewTextBox.ReadOnly = true;
            this.aDDRESSDataGridViewTextBox.Width = 400;
            // 
            // tsProductsMenu
            // 
            this.tsProductsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tsProductsMenu.AutoSize = false;
            this.tsProductsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.tsProductsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.tsProductsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsProductsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNewProduct,
            this.tsbtnEditProduct,
            this.tsbtnRemoveProduct});
            this.tsProductsMenu.Location = new System.Drawing.Point(1, 237);
            this.tsProductsMenu.Name = "tsProductsMenu";
            this.tsProductsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsProductsMenu.Size = new System.Drawing.Size(553, 24);
            this.tsProductsMenu.TabIndex = 3;
            // 
            // tsbtnNewProduct
            // 
            this.tsbtnNewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNewProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewProduct.Name = "tsbtnNewProduct";
            this.tsbtnNewProduct.Size = new System.Drawing.Size(35, 21);
            this.tsbtnNewProduct.Text = "New";
            this.tsbtnNewProduct.ToolTipText = "Create New Product";
            this.tsbtnNewProduct.Click += new System.EventHandler(this.tsbtnNewProduct_Click);
            // 
            // tsbtnEditProduct
            // 
            this.tsbtnEditProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnEditProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditProduct.Name = "tsbtnEditProduct";
            this.tsbtnEditProduct.Size = new System.Drawing.Size(31, 21);
            this.tsbtnEditProduct.Text = "Edit";
            this.tsbtnEditProduct.ToolTipText = "Edit Selected Product";
            this.tsbtnEditProduct.Click += new System.EventHandler(this.tsbtnEditProduct_Click);
            // 
            // tsbtnRemoveProduct
            // 
            this.tsbtnRemoveProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnRemoveProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRemoveProduct.Name = "tsbtnRemoveProduct";
            this.tsbtnRemoveProduct.Size = new System.Drawing.Size(54, 21);
            this.tsbtnRemoveProduct.Text = "Remove";
            this.tsbtnRemoveProduct.ToolTipText = "Remove Selected Product";
            this.tsbtnRemoveProduct.Click += new System.EventHandler(this.tsbtnRemoveProduct_Click);
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUCTNAMEDataGridViewTextBox,
            this.pRICEDataGridViewTextBox,
            this.dESCRIPTIONDataGridViewTextBox});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.dgvProducts.Location = new System.Drawing.Point(0, 263);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.ShowCellErrors = false;
            this.dgvProducts.ShowCellToolTips = false;
            this.dgvProducts.ShowEditingIcon = false;
            this.dgvProducts.ShowRowErrors = false;
            this.dgvProducts.Size = new System.Drawing.Size(552, 232);
            this.dgvProducts.TabIndex = 4;
            // 
            // pRODUCTNAMEDataGridViewTextBox
            // 
            this.pRODUCTNAMEDataGridViewTextBox.DataPropertyName = "Name";
            this.pRODUCTNAMEDataGridViewTextBox.HeaderText = "Product Name";
            this.pRODUCTNAMEDataGridViewTextBox.Name = "pRODUCTNAMEDataGridViewTextBox";
            this.pRODUCTNAMEDataGridViewTextBox.ReadOnly = true;
            this.pRODUCTNAMEDataGridViewTextBox.Width = 150;
            // 
            // pRICEDataGridViewTextBox
            // 
            this.pRICEDataGridViewTextBox.DataPropertyName = "Price";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.pRICEDataGridViewTextBox.DefaultCellStyle = dataGridViewCellStyle5;
            this.pRICEDataGridViewTextBox.HeaderText = "Price";
            this.pRICEDataGridViewTextBox.Name = "pRICEDataGridViewTextBox";
            this.pRICEDataGridViewTextBox.ReadOnly = true;
            // 
            // dESCRIPTIONDataGridViewTextBox
            // 
            this.dESCRIPTIONDataGridViewTextBox.DataPropertyName = "Description";
            this.dESCRIPTIONDataGridViewTextBox.HeaderText = "Description";
            this.dESCRIPTIONDataGridViewTextBox.Name = "dESCRIPTIONDataGridViewTextBox";
            this.dESCRIPTIONDataGridViewTextBox.ReadOnly = true;
            this.dESCRIPTIONDataGridViewTextBox.Width = 300;
            // 
            // frmSuppliersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 493);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.tsProductsMenu);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.tsSuppliersMenu);
            this.Name = "frmSuppliersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suppliers Management";
            this.Load += new System.EventHandler(this.frmSuppliersManagement_Load);
            this.tsSuppliersMenu.ResumeLayout(false);
            this.tsSuppliersMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.tsProductsMenu.ResumeLayout(false);
            this.tsProductsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSuppliersMenu;
        private System.Windows.Forms.ToolStripButton tsbtnNewSupplier;
        private System.Windows.Forms.ToolStripButton tsbtnEditSupplier;
        private System.Windows.Forms.ToolStripButton tsbtnRemoveSupplier;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.ToolStrip tsProductsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnNewProduct;
        private System.Windows.Forms.ToolStripButton tsbtnEditProduct;
        private System.Windows.Forms.ToolStripButton tsbtnRemoveProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERNAMEDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBox;
    }
}