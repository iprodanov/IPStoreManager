using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPStoreManager.Validation;

namespace IPStoreManager.GUI.Forms.SuppliersManagement
{
    public partial class frmEditSupplier : Form
    {
        #region Members

        Supplier supplier;

        #endregion

        #region Constructors

        public frmEditSupplier(Supplier supplier)
        {
            InitializeComponent();
            this.supplier = supplier;
        }

        #endregion

        #region Methods

        private void SetFormTitle()
        {
            string formTitle;
            if (supplier.SupplierID == 0)
            {
                formTitle = "New";
            }
            else
            {
                formTitle = "Edit";
            }
            this.Text = string.Format(this.Text, formTitle);
        }

        private void FillSupplierInfo()
        {
            this.tbSupplierName.Text = supplier.Name;
            this.tbSupplierAddress.Text = supplier.Address;
        }

        private void GetSupplierInfo()
        {
            supplier.Name = this.tbSupplierName.Text;
            supplier.Address = this.tbSupplierAddress.Text;
        }

        private void AdjustControlsAvailability()
        {
            bool invalidSupplierName = TextBoxInput.MissingText(tbSupplierName);
            this.btnOK.Enabled = invalidSupplierName ? false : true;
        }

        #endregion

        #region Event Hendlers

        private void frmEditSupplier_Load(object sender, EventArgs e)
        {
            SetFormTitle();
            TextBoxInput.InitializeErrorProvider();
            if (supplier.SupplierID != 0)
            {
                FillSupplierInfo();
            }
            AdjustControlsAvailability();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GetSupplierInfo();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbSupplierName_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        #endregion
    }
}
