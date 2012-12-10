using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPStoreManager.Validation;

namespace IPStoreManager.GUI.Forms.WarehouseManagement
{
    public partial class frmEditShippment : Form
    {
        #region Members

        Product product;

        #endregion

        #region Constructors

        public frmEditShippment(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        #endregion

        #region Methods

        private void FillProductInfo()
        {
            this.tbProductName.Text = product.Name;
            this.tbDescription.Text = product.Description;
            this.tbShippment.Text = "1";
        }

        private void GetShippmentQuantity()
        {
            product.Stock += Int32.Parse(this.tbShippment.Text);
        }

        private void AdjustControlsAvailability()
        {
            bool shippmentMissing = TextBoxInput.MissingText(tbShippment);
            this.btnOK.Enabled = shippmentMissing ? false : true;
        }

        #endregion

        #region Event Handlers

        private void frmEditShippment_Load(object sender, EventArgs e)
        {
            TextBoxInput.InitializeErrorProvider();
            FillProductInfo();
        }

        private void tbShippment_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (InputKey.ValidNumberKey(e))
            {
                e.SuppressKeyPress = false;
            }
        }

        private void tbShippment_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GetShippmentQuantity();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
