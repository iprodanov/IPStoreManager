using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using IPStoreManager.Validation;

namespace IPStoreManager.GUI.Forms.SuppliersManagement
{
    public partial class frmEditProduct : Form
    {
        #region Members

        Product product;

        #endregion

        #region Constructors

        public frmEditProduct(Product product)
        {
            InitializeComponent();
            this.product = product;
            
        }

        #endregion

        #region Methods

        private void SetFormTitle()
        {
            if (product.ProductID == 0)
            {
                this.Text = string.Format(this.Text, "New");
            }
            else
            {
                this.Text = string.Format(this.Text, "Edit");
            }
        }

        private void FillProductInfo()
        {
            this.tbProductName.Text = product.Name;
            this.tbDescription.Text = product.Description;
            this.tbPrice.Text = product.Price.ToString();
        }

        private void GetProductInfo()
        {
            product.Name = this.tbProductName.Text;
            product.Description = this.tbDescription.Text;
            InputLanguage lang = InputLanguage.CurrentInputLanguage;
            product.Price = decimal.Parse(this.tbPrice.Text, InputLanguage.CurrentInputLanguage.Culture);
        }

        private void AdjustControlsAvailability()
        {
            bool invalidProductName = TextBoxInput.MissingText(tbProductName);
            bool invalidPrice = TextBoxInput.MissingText(tbPrice) ||
                                TextBoxInput.ContainsDecimalPointOnly(tbPrice) ||
                                TextBoxInput.GreaterThanDecimalMaxValue(tbPrice);
            this.btnOK.Enabled = (invalidProductName || invalidPrice) ? false : true;
        }

        #endregion

        #region Event Handlers

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            SetFormTitle();
            TextBoxInput.InitializeErrorProvider();
            if (product.ProductID > 0)
            {
                FillProductInfo();
            }
            AdjustControlsAvailability();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GetProductInfo();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void tbPrice_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (InputKey.ValidNumberKey(e))
            {
                e.SuppressKeyPress = false;
            }
            else if(InputKey.IsDecimalPoint(e))
            {
                if (!TextBoxInput.ContainsDecimalPoint(tbPrice) ||
                    TextBoxInput.AllTextSelected(tbPrice) ||
                    TextBoxInput.SelectionContainsDecimalPoint(tbPrice))
                {
                    e.SuppressKeyPress = false;
                }
            }
        }
        
        #endregion
    }
}
