using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPStoreManager.GUI.Forms.Reports
{
    public partial class frmSales : Form
    {
        #region Members

        private List<SaleItem> allSaleItems;
        private List<SaleItem> filteredSales;
        private BindingSource bsSales;

        #endregion

        #region Constructors

        public frmSales()
        {
            InitializeComponent();
            bsSales = new BindingSource();
            dgvSales.AutoGenerateColumns = false;
            BindSalesData();
        }

        #endregion

        #region Methods

        private void LoadSalesData()
        {
            using (var db = new StoreManagerContext())
            {
                allSaleItems = db.SaleItems.Include("Product").Include("Sale").ToList();
            }
            bsSales.DataSource = allSaleItems;
        }

        private void BindSalesData()
        {
            dgvSales.DataSource = bsSales;
        }

        private void ApplyFilter()
        {
            FilterSaleItems();
            bsSales.DataSource = filteredSales;
            CalculateTotal(filteredSales);
        }

        private void ClearFilter()
        {
            bsSales.DataSource = allSaleItems;
            CalculateTotal(allSaleItems);
        }

        private void FilterSaleItems()
        {
            if (cbFilterElement.Text == "Sale")
            {
                FilterBySaleID();
            }
            else if (cbFilterElement.Text == "Product Name")
            {
                FilterByProductName();
            }
        }

        private void FilterBySaleID()
        {
            int id = int.Parse(tstbText.Text);
            filteredSales = (from si in allSaleItems
                             where si.SaleID == id
                             select si).ToList();
        }

        private void FilterByProductName()
        {
            string name = tstbText.Text;
            filteredSales = (from si in allSaleItems
                             where si.Product.Name.Contains(name)
                             select si).ToList();
        }

        private void CalculateTotal(List<SaleItem> saleItems)
        {
            decimal total = saleItems.Sum(item => item.Product.Price * item.Quantity);
            tbTotal.Text = String.Format("{0:c}", total);
            
        }

        private void AdjustAvailabilityControls()
        {
            this.tstbText.Enabled = cbFilterElement.Text != String.Empty ? true : false;
        }

        #endregion

        #region Event Handlers

        private void frmSales_Load(object sender, EventArgs e)
        {
            LoadSalesData();
            if (bsSales.Current != null)
            {
                CalculateTotal(allSaleItems);
            }
            else
            {
                tbTotal.Text = String.Empty;
            }
            AdjustAvailabilityControls();
        }

        private void tstbText_TextChanged(object sender, EventArgs e)
        {
            if (tstbText.Text != String.Empty)
            {
                ApplyFilter();
            }
            else
            {
                ClearFilter();
            }
        }

        private void cbFilterElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustAvailabilityControls();
        }

        private void dgvSales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                SaleItem saleItem = (SaleItem)row.DataBoundItem;
                var product = saleItem.Product;
                row.Cells[ProductNameColumn.Index].Value = product.Name;
                row.Cells[PriceColumn.Index].Value = product.Price;
                row.Cells[DateColumn.Index].Value = saleItem.Sale.SaleTimeStamp;
            }
        }

        #endregion
    }
}
