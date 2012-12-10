namespace IPStoreManager.GUI.Forms.SalesManagement
{
    partial class frmSalesTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesTerminal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsSaleItems = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddToCart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditCartItem = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRemoveFromCart = new System.Windows.Forms.ToolStripButton();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.SupplierNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsSaleItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tsSaleItems
            // 
            this.tsSaleItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.tsSaleItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSaleItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddToCart,
            this.tsbtnEditCartItem,
            this.tsbtnRemoveFromCart});
            this.tsSaleItems.Location = new System.Drawing.Point(0, 0);
            this.tsSaleItems.Name = "tsSaleItems";
            this.tsSaleItems.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsSaleItems.Size = new System.Drawing.Size(606, 25);
            this.tsSaleItems.TabIndex = 0;
            this.tsSaleItems.Text = "toolStrip1";
            // 
            // tsbtnAddToCart
            // 
            this.tsbtnAddToCart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddToCart.Image")));
            this.tsbtnAddToCart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddToCart.Name = "tsbtnAddToCart";
            this.tsbtnAddToCart.Size = new System.Drawing.Size(33, 22);
            this.tsbtnAddToCart.Text = "Add";
            this.tsbtnAddToCart.Click += new System.EventHandler(this.tsbtnAddToCart_Click);
            // 
            // tsbtnEditCartItem
            // 
            this.tsbtnEditCartItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnEditCartItem.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditCartItem.Image")));
            this.tsbtnEditCartItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditCartItem.Name = "tsbtnEditCartItem";
            this.tsbtnEditCartItem.Size = new System.Drawing.Size(31, 22);
            this.tsbtnEditCartItem.Text = "Edit";
            this.tsbtnEditCartItem.Click += new System.EventHandler(this.tsbtnEditCartItem_Click);
            // 
            // tsbtnRemoveFromCart
            // 
            this.tsbtnRemoveFromCart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnRemoveFromCart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRemoveFromCart.Image")));
            this.tsbtnRemoveFromCart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRemoveFromCart.Name = "tsbtnRemoveFromCart";
            this.tsbtnRemoveFromCart.Size = new System.Drawing.Size(54, 22);
            this.tsbtnRemoveFromCart.Text = "Remove";
            this.tsbtnRemoveFromCart.Click += new System.EventHandler(this.tsbtnRemoveFromCart_Click);
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.AllowUserToAddRows = false;
            this.dgvSaleItems.AllowUserToDeleteRows = false;
            this.dgvSaleItems.AllowUserToResizeRows = false;
            this.dgvSaleItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSaleItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.dgvSaleItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSaleItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSaleItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSaleItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierNameColumn,
            this.ProductNameColumn,
            this.PriceColumn,
            this.QuantityColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSaleItems.EnableHeadersVisualStyles = false;
            this.dgvSaleItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.dgvSaleItems.Location = new System.Drawing.Point(0, 26);
            this.dgvSaleItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSaleItems.MultiSelect = false;
            this.dgvSaleItems.Name = "dgvSaleItems";
            this.dgvSaleItems.ReadOnly = true;
            this.dgvSaleItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvSaleItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSaleItems.RowHeadersVisible = false;
            this.dgvSaleItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSaleItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleItems.ShowCellErrors = false;
            this.dgvSaleItems.ShowCellToolTips = false;
            this.dgvSaleItems.ShowEditingIcon = false;
            this.dgvSaleItems.ShowRowErrors = false;
            this.dgvSaleItems.Size = new System.Drawing.Size(606, 273);
            this.dgvSaleItems.TabIndex = 15;
            this.dgvSaleItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSaleItems_DataBindingComplete);
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotal.Location = new System.Drawing.Point(73, 323);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(148, 26);
            this.tbTotal.TabIndex = 20;
            this.tbTotal.Text = "0";
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(12, 323);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 26);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            // 
            // btnSale
            // 
            this.btnSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(544, 312);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(50, 50);
            this.btnSale.TabIndex = 19;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // SupplierNameColumn
            // 
            this.SupplierNameColumn.HeaderText = "Supplier Name";
            this.SupplierNameColumn.Name = "SupplierNameColumn";
            this.SupplierNameColumn.ReadOnly = true;
            this.SupplierNameColumn.Width = 200;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            this.ProductNameColumn.Width = 200;
            // 
            // PriceColumn
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PriceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "Quantity";
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // frmSalesTerminal
            // 
            this.AcceptButton = this.btnSale;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 374);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.dgvSaleItems);
            this.Controls.Add(this.tsSaleItems);
            this.Name = "frmSalesTerminal";
            this.Text = "Sales Terminal";
            this.Load += new System.EventHandler(this.frmSalesTerminal_Load);
            this.tsSaleItems.ResumeLayout(false);
            this.tsSaleItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSaleItems;
        private System.Windows.Forms.ToolStripButton tsbtnAddToCart;
        private System.Windows.Forms.ToolStripButton tsbtnEditCartItem;
        private System.Windows.Forms.ToolStripButton tsbtnRemoveFromCart;
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
    }
}