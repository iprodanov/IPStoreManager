namespace IPStoreManager.GUI.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnManageUsers = new System.Windows.Forms.ToolStripButton();
            this.tsbtnManageSuppliers = new System.Windows.Forms.ToolStripButton();
            this.tsbtnManageWarehouse = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReports = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSalesTerminal = new System.Windows.Forms.ToolStripButton();
            this.pnlMenu.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.tsMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(764, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(120, 562);
            this.pnlMenu.TabIndex = 0;
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnManageUsers,
            this.tsbtnManageSuppliers,
            this.tsbtnManageWarehouse,
            this.tsbtnReports,
            this.toolStripSeparator1,
            this.tsbtnSalesTerminal});
            this.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMenu.Size = new System.Drawing.Size(120, 562);
            this.tsMenu.TabIndex = 1;
            this.tsMenu.Text = "tsMenu";
            // 
            // tsbtnManageUsers
            // 
            this.tsbtnManageUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnManageUsers.Image")));
            this.tsbtnManageUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnManageUsers.Name = "tsbtnManageUsers";
            this.tsbtnManageUsers.Size = new System.Drawing.Size(118, 19);
            this.tsbtnManageUsers.Text = "Manage Users";
            this.tsbtnManageUsers.Click += new System.EventHandler(this.tsbtnManageUsers_Click);
            // 
            // tsbtnManageSuppliers
            // 
            this.tsbtnManageSuppliers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnManageSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnManageSuppliers.Image")));
            this.tsbtnManageSuppliers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnManageSuppliers.Name = "tsbtnManageSuppliers";
            this.tsbtnManageSuppliers.Size = new System.Drawing.Size(118, 19);
            this.tsbtnManageSuppliers.Text = "Manage Suppliers";
            this.tsbtnManageSuppliers.Click += new System.EventHandler(this.tsbtnManageSuppliers_Click);
            // 
            // tsbtnManageWarehouse
            // 
            this.tsbtnManageWarehouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnManageWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnManageWarehouse.Image")));
            this.tsbtnManageWarehouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnManageWarehouse.Name = "tsbtnManageWarehouse";
            this.tsbtnManageWarehouse.Size = new System.Drawing.Size(118, 19);
            this.tsbtnManageWarehouse.Text = "Manage Warehouse";
            this.tsbtnManageWarehouse.Click += new System.EventHandler(this.tsbtnManageWarehouse_Click);
            // 
            // tsbtnReports
            // 
            this.tsbtnReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnReports.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReports.Image")));
            this.tsbtnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReports.Name = "tsbtnReports";
            this.tsbtnReports.Size = new System.Drawing.Size(118, 19);
            this.tsbtnReports.Text = "Reports";
            this.tsbtnReports.Click += new System.EventHandler(this.tsbtnReports_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // tsbtnSalesTerminal
            // 
            this.tsbtnSalesTerminal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSalesTerminal.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalesTerminal.Image")));
            this.tsbtnSalesTerminal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalesTerminal.Name = "tsbtnSalesTerminal";
            this.tsbtnSalesTerminal.Size = new System.Drawing.Size(118, 19);
            this.tsbtnSalesTerminal.Text = "Sales Terminal";
            this.tsbtnSalesTerminal.Click += new System.EventHandler(this.tsbtnSalesTerminal_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Store Management";
            this.pnlMenu.ResumeLayout(false);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnManageUsers;
        private System.Windows.Forms.ToolStripButton tsbtnManageSuppliers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnManageWarehouse;
        private System.Windows.Forms.ToolStripButton tsbtnSalesTerminal;
        private System.Windows.Forms.ToolStripButton tsbtnReports;
    }
}

