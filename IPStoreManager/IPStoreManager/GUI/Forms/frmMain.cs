using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPStoreManager.GUI.Forms.UsersManagement;
using IPStoreManager.GUI.Forms.WarehouseManagement;
using IPStoreManager.GUI.Forms.SuppliersManagement;
using IPStoreManager.GUI.Forms.SalesManagement;
using IPStoreManager.GUI.Forms.Reports;

namespace IPStoreManager.GUI.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbtnManageUsers_Click(object sender, EventArgs e)
        {
            frmUserManagement frmUserManagement = new frmUserManagement();
            frmUserManagement.MdiParent = this;
            frmUserManagement.Show();
        }

        private void tsbtnManageSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliersManagement frmSuppliersManagement = new frmSuppliersManagement();
            frmSuppliersManagement.MdiParent = this;
            frmSuppliersManagement.Show();
        }

        private void tsbtnManageWarehouse_Click(object sender, EventArgs e)
        {
            frmWarehouseManagement frmWarehouseManagement = new frmWarehouseManagement();
            frmWarehouseManagement.MdiParent = this;
            frmWarehouseManagement.Show();
        }

        private void tsbtnSalesTerminal_Click(object sender, EventArgs e)
        {
            frmSalesTerminal frmSalesTerminal = new frmSalesTerminal();
            frmSalesTerminal.Show();
        }

        private void tsbtnReports_Click(object sender, EventArgs e)
        {
            frmSales frmSales = new frmSales();
            frmSales.MdiParent = this;
            frmSales.Show();
        }
    }
}
